/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jesus.client;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Calendar;
import java.util.Date;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.ERROR_MESSAGE;
import socket.server.dataBaseConn;
/**
 *
 * @author Jesus
 */
public class clientWidow extends javax.swing.JFrame {
    private Socket socket = null, socket_b = null;
    private DataOutputStream out = null;
    private BufferedReader br = null;
    private DataInputStream in = null;
    private boolean con = true;
    private String username = "";
    private ServerSocket sv = null;
    /**
     * Creates new form clientWidow
     */
    public clientWidow() {
        initComponents();
        username = getUsername();
        welcomeLabel.setText("Welcome " + username);
        this.receivingProgress.setVisible(false);
        this.BarLBL.setVisible(false);
    }
    
    public void conn(){
        try{
            log.append("Client started. Connecting to the server...\n");
            socket = new Socket("190.73.100.142", 3000);
            if (socket.isConnected()){
                out = new DataOutputStream(socket.getOutputStream());
                out.writeUTF(username);
                log.append("You're now connecter to the server.\n");
                while (con)
                    wich();
            }
            else{
                while (!socket.isConnected()){
                    socket = new Socket("190.73.100.142", 3000);
                }
                out = new DataOutputStream(socket.getOutputStream());
                out.writeUTF(username);
                log.append("You're now connected to the Server.");
                while(con)
                     wich();
            }
        } catch (IOException e){}
    }
    
    private void wich(){
        try{
            in = new DataInputStream(socket.getInputStream());
            if (in.readBoolean())
                readText();
            else
                readFile();
        }catch (IOException e){}
    }
    
    private void readFile(){
        String senderName = "", fileName = "", originalPath = "", sentToPath = "";
      int fileSize = 0;
        try{
            Calendar calendar = Calendar.getInstance();
            Date date = calendar.getTime();
            File dir = new File("Received_Files");
            if (!dir.exists())
                dir.mkdir();
            this.in = new DataInputStream(new BufferedInputStream(this.socket.getInputStream()));
            senderName = in.readUTF();
            fileName = in.readUTF();
            fileSize = in.readInt();
            originalPath = in.readUTF();
            log.append(senderName + " send the file " + fileName + " of size " + fileSize + " bytes.\n");
            File dir2 = new File("Received_Files\\From_" + senderName + "_To_" + username);
            if (!dir2.exists())
                dir2.mkdir();
            sentToPath = "Received_Files\\From_" + senderName + "_To_" + username + "\\" + fileName;
            this.BarLBL.setVisible(true);
            this.BarLBL.setText("Receiving " + fileName + " from " + senderName);
            this.receivingProgress.setVisible(true);
            this.receivingProgress.setMinimum(0);
            this.receivingProgress.setMaximum(fileSize);
            FileOutputStream fos = new FileOutputStream(sentToPath);
            int count;
            for(count = 0; count < fileSize; count++){
                fos.write(in.read());
                this.receivingProgress.setValue(count);
            }
            this.BarLBL.setVisible(false);
            this.receivingProgress.setVisible(false);
            dataBaseConn dbC = new dataBaseConn();
            dbC.Insert(senderName, originalPath, sentToPath, "", date.toString());
        } catch (IOException e){}
    }
    
    private void readText(){
        try{
            log.append(in.readUTF());
        } catch (IOException e){}
    }
    
    public void appenText(String appen){
        this.log.append(appen);
    }
    
    private String getUsername(){
        String a = "";
        try{
            File nickFile = new File ("username.txt");
            FileReader readName = new FileReader (nickFile);
            BufferedReader bReadName = new BufferedReader (readName);
            a = bReadName.readLine();
            bReadName.close();
        } catch (IOException e){}
        return a;
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        welcomeLabel = new javax.swing.JLabel();
        fileRouteTxt = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        textArea = new javax.swing.JTextArea();
        sendFlBtn = new javax.swing.JButton();
        sendTxBtn = new javax.swing.JButton();
        closeConnBtn = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        log = new javax.swing.JTextArea();
        msgBoxLBL = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        flSdgLBL = new javax.swing.JLabel();
        receivingProgress = new javax.swing.JProgressBar();
        BarLBL = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        welcomeLabel.setText("Welcome ");

        fileRouteTxt.setToolTipText("Type here the location route on your hard drive of the file you want to send");

        textArea.setColumns(20);
        textArea.setRows(5);
        textArea.setToolTipText("Type here the message you want to send");
        jScrollPane1.setViewportView(textArea);

        sendFlBtn.setText("Send file");
        sendFlBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                sendFlBtnActionPerformed(evt);
            }
        });

        sendTxBtn.setText("Send Text");
        sendTxBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                sendTxBtnActionPerformed(evt);
            }
        });

        closeConnBtn.setText("Close connection");
        closeConnBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                closeConnBtnActionPerformed(evt);
            }
        });

        log.setEditable(false);
        log.setColumns(20);
        log.setRows(5);
        jScrollPane2.setViewportView(log);

        msgBoxLBL.setText("Message box");

        jLabel2.setText("CHAT");

        flSdgLBL.setText("File sending box");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(56, 56, 56)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(welcomeLabel, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(fileRouteTxt, javax.swing.GroupLayout.PREFERRED_SIZE, 215, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(39, 39, 39)
                                .addComponent(sendFlBtn))
                            .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 185, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(flSdgLBL, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 588, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addContainerGap(417, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 256, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(msgBoxLBL, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addComponent(sendTxBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 129, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE))))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(receivingProgress, javax.swing.GroupLayout.PREFERRED_SIZE, 242, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(BarLBL, javax.swing.GroupLayout.PREFERRED_SIZE, 455, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(23, 23, 23))
            .addGroup(layout.createSequentialGroup()
                .addGap(433, 433, 433)
                .addComponent(closeConnBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 142, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(welcomeLabel, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 93, Short.MAX_VALUE)
                .addComponent(jLabel2)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 133, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(BarLBL, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(5, 5, 5)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(msgBoxLBL)
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(15, 15, 15)
                        .addComponent(flSdgLBL)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(receivingProgress, javax.swing.GroupLayout.PREFERRED_SIZE, 21, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(sendTxBtn, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(54, 54, 54)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(fileRouteTxt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(sendFlBtn))
                .addGap(61, 61, 61)
                .addComponent(closeConnBtn)
                .addGap(18, 18, 18))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void sendTxBtnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_sendTxBtnActionPerformed
        try {
            Calendar calendar = Calendar.getInstance();
            Date date = calendar.getTime();
            dataBaseConn dbC = new dataBaseConn();
            dbC.Insert(username, "", "", textArea.getText(), date.toString());
            out = new DataOutputStream(socket.getOutputStream());
            out.writeBoolean(true);
            out.writeUTF(username + ": " + textArea.getText());
            this.textArea.setText("");
        } catch (IOException ex) {}
    }//GEN-LAST:event_sendTxBtnActionPerformed

    private void closeConnBtnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_closeConnBtnActionPerformed
       con = false;
        try{
            out.close();
            socket.close();
        } catch (IOException ex){}
    }//GEN-LAST:event_closeConnBtnActionPerformed

    private void sendFlBtnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_sendFlBtnActionPerformed
        File fileToSend = new File(fileRouteTxt.getText());
        if (!fileToSend.exists())
            JOptionPane.showMessageDialog(sendFlBtn, "File not found.", "ERROR", ERROR_MESSAGE);
        else{
            try{
                log.append(username + " sent the file " + fileToSend.getName() + " of size " 
                    + (int) fileToSend.length() + " bytes.\n");
                out = new DataOutputStream(socket.getOutputStream());
                out.writeBoolean(false);
                out.writeUTF(username);
                out.writeUTF(fileToSend.getName());
                out.writeInt((int) fileToSend.length());
                out.writeUTF(fileToSend.getAbsolutePath());
                int count;
                byte[] buffer = new byte[(int) fileToSend.length()];
                receivingProgress.setVisible(true);
                BarLBL.setVisible(true);
                BarLBL.setText("Sending " + fileToSend.getName());
                receivingProgress.setMinimum(0);
                receivingProgress.setMaximum((int) fileToSend.length());
                OutputStream outa = socket.getOutputStream();
                BufferedInputStream in = new BufferedInputStream(new FileInputStream(fileToSend));
                for (count = 0; count < (int) fileToSend.length(); count++) {
                    outa.write(in.read());
                    outa.flush();
                    this.receivingProgress.setValue(count);
                    validate();
                }
                this.fileRouteTxt.setText("");
           } catch (IOException e){}
        }
    }//GEN-LAST:event_sendFlBtnActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel BarLBL;
    private javax.swing.JButton closeConnBtn;
    private javax.swing.JTextField fileRouteTxt;
    private javax.swing.JLabel flSdgLBL;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextArea log;
    private javax.swing.JLabel msgBoxLBL;
    private javax.swing.JProgressBar receivingProgress;
    private javax.swing.JButton sendFlBtn;
    private javax.swing.JButton sendTxBtn;
    private javax.swing.JTextArea textArea;
    private javax.swing.JLabel welcomeLabel;
    // End of variables declaration//GEN-END:variables
}
