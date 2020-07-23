package com.java.main.medidor.christ;

import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Main extends Medidor 
{
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;

	public static void main(String[] args) 
	{
		EventQueue.invokeLater(new Runnable() 
		{
			public void run() 
			{
				try 
				{
					Main frame = new Main();
					frame.setVisible(true);
				} catch (Exception e) 
				{
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Main() 
	{
		setTitle("Medidor aleatorio");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(800, 600);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("Velocidad");
		lblNewLabel.setBounds(195, 99, 62, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Temperatura");
		lblNewLabel_1.setBounds(389, 99, 80, 14);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Presion");
		lblNewLabel_2.setBounds(595, 99, 46, 14);
		contentPane.add(lblNewLabel_2);
		
		JButton btnNewButton = new JButton("Medir");
		btnNewButton.addActionListener(new ActionListener() 
		{
			public void actionPerformed(ActionEvent e) 
			{
				setValue();
				repaint();
				
			}
		});
		btnNewButton.setFont(new Font("Tahoma", Font.BOLD, 14));
		btnNewButton.setBounds(46, 273, 89, 92);
		contentPane.add(btnNewButton);
		
		JLabel MaxV = new JLabel("New label");
		MaxV.setBounds(253, 164, 119, 14);
		MaxV.setText("Limite: " + LimitV + "km/h");
		contentPane.add(MaxV);
		
		JLabel MaxT = new JLabel("New label");
		MaxT.setBounds(458, 164, 119, 14);
		MaxT.setText("Limite: " + LimitT + "°C");
		contentPane.add(MaxT);
		
		JLabel MaxP = new JLabel("New label");
		MaxP.setBounds(654, 164, 120, 14);
		MaxP.setText("Limite: " + LimitP + "kPa");
		contentPane.add(MaxP);
		
		ActualV = new JLabel();
		ActualV.setBounds(253, 298, 119, 14);
		contentPane.add(ActualV);
		
		ActualT = new JLabel();
		ActualT.setBounds(458, 298, 119, 14);
		contentPane.add(ActualT);
		
		ActualP = new JLabel();
		ActualP.setBounds(654, 298, 120, 14);
		contentPane.add(ActualP);
	}
}
