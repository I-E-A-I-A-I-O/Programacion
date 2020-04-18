/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package socket.server;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Calendar;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Jesus
 */
public class dataBaseConn {
    private Connection conn;
    private String URL = "jdbc:postgresql://186.93.213.32:5432/usersdata";
    private String User = "postgres";
    private String Pass = "JeSuS20o*";
    private String Driver = "org.postgresql.Driver";
    private Statement stmt;
    private ResultSet rs;
    
    public dataBaseConn(){
        try{
            Class.forName(Driver);
            conn = DriverManager.getConnection(URL, User, Pass);
        } catch (ClassNotFoundException | SQLException e){
        }
    }
    
    public void Insert(String UserName, String ogPath, String newPath, String message, String date){
        try{
            stmt = conn.createStatement();
            stmt.executeUpdate("INSERT INTO svlog VALUES('" + UserName + "', '" + ogPath + "', '"
            + newPath + "', '" + message + "', '" + date + "');");
            stmt.close();
        } catch (SQLException e){
            e.printStackTrace();
        }
    }
}
