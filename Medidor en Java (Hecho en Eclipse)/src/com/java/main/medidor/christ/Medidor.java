package com.java.main.medidor.christ;

import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;
import javax.swing.JFrame;
import javax.swing.JLabel;

public abstract class Medidor extends JFrame
{
	private static final long serialVersionUID = 1L;
	int Velocidad, Temperatura, Presion, LimitV = 200, LimitP = 24000, LimitT = 350, Height = 300, Width = 50, Y = 200;
	JLabel ActualV, ActualT, ActualP;
	
	public void paint(Graphics g)
	{
		super.paintComponents(g);
		setValue();
		int X = Velocidad;
		g.setColor(Color.BLACK);
		g.drawRect(200, Y, Width, Height);
		g.fillRect(200, Y + (Height - ((int) (Height * Percentage(LimitV, X)))), Width, (int) (Height * Percentage(LimitV, X)));
		g.setColor(Color.BLUE);
		g.drawRect(400, 200, Width, 300);
		X = Temperatura;
		g.fillRect(400, Y + (Height - ((int) (Height * Percentage(LimitT, X)))), Width, (int) (Height * Percentage(LimitT, X)));
		g.setColor(Color.RED);
		g.drawRect(600, 200, Width, 300);
		X = Presion;
		g.fillRect(600, Y + (Height - ((int) (Height * Percentage(LimitP, X)))), Width, (int) (Height * Percentage(LimitP, X)));
	}
	
	float Percentage(int a, int b)
	{
		float c = a, d = b;
		return (1 / (c / d));
	}
	
	void setValue()
	{
		Random ran = new Random();
		Velocidad = ran.nextInt(LimitV + 1);
		Temperatura = ran.nextInt(LimitT + 1);
		Presion = ran.nextInt(LimitP + 1);
		ActualV.setText("Valor: " + Velocidad + "km/h");
		ActualT.setText("Valor: " + Temperatura + "°C");
		ActualP.setText("Valor: " + Presion + "kPa");
	}
}
