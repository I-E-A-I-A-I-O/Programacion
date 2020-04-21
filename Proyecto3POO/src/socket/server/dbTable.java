package socket.server;

import javax.swing.JFrame;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.table.DefaultTableModel;
import java.sql.*;
import java.lang.ClassNotFoundException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class dbTable {
    private DefaultTableModel dft;
    private JTable tb;
    private JScrollPane scp;
    private JFrame frame;
    private Connection conn;
    private String URL = "jdbc:postgresql://186.91.59.230:5432/usersdata";
    private String User = "postgres";
    private String Pass = "JeSuS20o*";
    private String Driver = "org.postgresql.Driver";
    private Statement stmt;
    private ResultSet rs;
    private Object[] columnNames = new Object[] {"Username", "Message", "Message_Date", "File_OG_Path", "File_New_Path"};
    private Object[] data = new Object[5];
	
    public dbTable() {
        frame = new JFrame("Messages log database");
	dft = new DefaultTableModel();
	dft.setColumnIdentifiers(columnNames);
        try {
            try {
                Class.forName(Driver);
            } catch (ClassNotFoundException ex) {}
            conn = DriverManager.getConnection(URL, User, Pass);
            stmt = conn.createStatement();
            rs = stmt.executeQuery("SELECT * FROM svlog");
            while (rs.next()) {
                data[0] = rs.getObject("username");
                data[1] = rs.getObject("Message");
                data[2] = rs.getObject("sentdate");
                data[3] = rs.getObject("originalpath");
                data[4] = rs.getObject("sentpath");
                dft.addRow(data);
            }
            rs.close();
            conn.close();
        } catch (SQLException e){}
        tb = new JTable(dft);
        scp = new JScrollPane(tb);
        tb.setFillsViewportHeight(true);
        frame.add(scp);
        frame.setSize(1024, 768);
        frame.setVisible(true);
    }	 	
}
