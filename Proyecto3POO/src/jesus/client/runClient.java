/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jesus.client;

/**
 *
 * @author Jesus
 */
public class runClient {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       clientWidow c = new clientWidow();
       c.setVisible(true);
       c.conn();
    }  
}
