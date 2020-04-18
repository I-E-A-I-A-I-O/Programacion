/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package socket.server;

/**
 *
 * @author Jesus
 */
public class runServer {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        serverWindow A = new serverWindow();
        A.setVisible(true);
        A.conn();
    }
    
}
