package socket.server;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Calendar;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ConnectionHandler implements Runnable {
  private Socket s = null;
  
  private serverWindow sw = null;
  
  PrintWriter abc = null;
  
  private boolean con = false;
  
  private DataInputStream in = null;
  
  private DataOutputStream out = null;
  
  public ConnectionHandler(Socket socket, serverWindow a) {
    this.s = socket;
    this.sw = a;
  }
  
  public void run() {
    this.sw.appenText("Client with direction: " + this.s.getRemoteSocketAddress().toString() + " has connected.\n");
      try {
          in = new DataInputStream(new BufferedInputStream(this.s.getInputStream()));
          sw.broadcast(in.readUTF() + " has entered the chat.");
      } catch (IOException ex) {}
    while (!this.con)
      wich(); 
  }
  
  public void wich() {
    try {
        in = new DataInputStream(new BufferedInputStream(this.s.getInputStream()));
        if (in.readBoolean())
            readText(); 
        else
            readFile();
    } catch (IOException i) {i.printStackTrace();}
  }
  
  public void readFile(){
      String username = "", fileName = "", originalPath = "", sentToPath = "";
      int fileSize = 0;
        try{
            Calendar calender = Calendar.getInstance();
            Date date = calender.getTime();
            File dir = new File("Received_Files");
            if (!dir.exists())
                dir.mkdir();
            this.in = new DataInputStream(new BufferedInputStream(this.s.getInputStream()));
            username = in.readUTF();
            fileName = in.readUTF();
            fileSize = in.readInt();
            originalPath = in.readUTF();
            sw.appenText(username + " sent the file " + fileName + " of size " + fileSize + " bytes.\n");
            File dir2 = new File("Received_Files\\From_" + username + "_To_Server");
            if (!dir2.exists())
                dir2.mkdir();
            sentToPath = "Received_Files\\From_" + username + "_To_Server" + "\\" + fileName;
            dataBaseConn dbC = new dataBaseConn();
            dbC.Insert(username, originalPath, sentToPath, "", date.toString());
            sw.setVisibles(true);
            sw.receivingLblSetText("Receiving " + fileName + " from " + username);
            sw.BarBounds(0, fileSize);
            FileOutputStream fos = new FileOutputStream(sentToPath);
            int count;
            for(count = 0; count < fileSize; count++){
                fos.write(in.read());
                sw.BarSetValue(count);
            }
            sw.setVisibles(false);
            File fts = new File(originalPath);
            sw.broadcastRemaining(fts, username, this);
        } catch (IOException e){} 
  }
  
  public void readText() {
    try {
      this.in = new DataInputStream(new BufferedInputStream(this.s.getInputStream()));
      String line = "";
      line = this.in.readUTF();
      if (line.length() > 0){
        this.sw.appenText(line + "\n");
        sw.broadcast(line);
      }
    } catch (IOException iOException) {}
  }
  
  public void sendTxt(String msg){
    try{
        out = new DataOutputStream(s.getOutputStream());
        out.writeBoolean(true);
        out.writeUTF(msg);
    } catch (IOException e){}
  }
  
  public void sendFile(File a, String whoSend){
        try{
            out = new DataOutputStream(s.getOutputStream());
            out.writeBoolean(false);
            out.writeUTF(whoSend);
            out.writeUTF(a.getName());
            out.writeInt((int) a.length());
            out.writeUTF(a.getAbsolutePath());
            int count;
            byte[] buffer = new byte[(int) a.length()];
            OutputStream outa = s.getOutputStream();
            BufferedInputStream in = new BufferedInputStream(new FileInputStream(a));
            sw.receivingFromlbl.setVisible(true);
            sw.receivingLblSetText("Sending " + a.getName());
            sw.receivingFromBar.setVisible(true);
            sw.receivingFromBar.setMinimum(0);
            sw.receivingFromBar.setMaximum((int) a.length());
            for (count = 0; count < (int) a.length(); count++) {
                    outa.write(in.read());
                    outa.flush();
                    sw.receivingFromBar.setValue(count);
                }
        } catch (IOException e){}
  }
}
