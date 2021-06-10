/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package za.ac.cput;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.Period;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;
import java.util.Date;
import java.util.Scanner;

/**
 *
 * @author MXO
 */
public class serialize 
{

    private static ArrayList<String> readFromFile(String stakeholderser) throws FileNotFoundException {
 ArrayList<String> Customer = new ArrayList<String>();
 try{
     Scanner sc = new Scanner(new File(stakeholderser));
     while(sc.hasNextLine()){
         Customer.add(sc.nextLine());
     }
     sc.close();
 }catch(FileNotFoundException e){
  e.printStackTrace();
 }
 return Customer;
    }

    private static void saveToFile(String stakeholderser, ArrayList<String> Customer) {
     Path filePath = Paths.get(stakeholderser);
     try{
         Files.write(filePath, Customer, Charset.defaultCharset());
     }catch (IOException e)
     {
         e.printStackTrace();
     }
    }
     public void serialize (Object obj,String Customer)
     {
         FileOutputStream fos;
         ObjectOutputStream out;
         try{
             fos = new FileOutputStream(Customer);
             out = new ObjectOutputStream(fos);
             out.writeObject(obj);
             out.close();
         }catch (IOException ex)
         {
           ex.printStackTrace();
           throw new RuntimeException(ex);
         }
     }
     

     
     public static void main(String[] args) throws ParseException {

         
      String L = "1981/01/27";
       String S = "1987/05/12";
       String M = "1993/01/24";
       String I = "1998/07/16";
       String E = "1999/11/27";
       String i = "2001/01/21";
       SimpleDateFormat sdf = new SimpleDateFormat("yyyy/MM/dd");
       Date d1 = sdf.parse(L);
       Date d2 = sdf.parse(S);
       Date d3 = sdf.parse(M);
       Date d4 = sdf.parse(E);
       Date d5 = sdf.parse(i);
       Calendar c = Calendar.getInstance();
       c.setTime(d1);
       c.setTime(d2);
       c.setTime(d3);
       c.setTime(d4);
       c.setTime(d5);
       int year = c.get(Calendar.YEAR);
       int month = c.get(Calendar.MONTH)+1;
       int date = c.get(Calendar.DATE);
       LocalDate l1 = LocalDate.of(year, month, date);
       LocalDate l2 = LocalDate.of(year, month, date);
       LocalDate l3 = LocalDate.of(year, month, date);
       LocalDate l4 = LocalDate.of(year, month, date);
       LocalDate l5 = LocalDate.of(year, month, date);
       LocalDate now1 = LocalDate.now();
       LocalDate now2 = LocalDate.now();
       LocalDate now3 = LocalDate.now();
       LocalDate now4 = LocalDate.now();
       LocalDate now5 = LocalDate.now();
       Period diff1 = Period.between(l1, now1);
       Period diff2 = Period.between(l2, now2);
       Period diff3 = Period.between(l3, now3);
       Period diff4 = Period.between(l4, now4);
       Period diff5 = Period.between(l5, now5);
         
        ArrayList<String>
                list = new ArrayList<String>();
        list.add("C150\t Luke\t Atmyass\t 1981-01-27\t"+diff1.getYears()+"\n");
        list.add("C130\t Stu\t Padassol\t 1987-05-18\t"+diff2.getYears()+"\n");
        list.add("C100\t Mike\t Rohsopht\t 1993-01-24\t"+diff3.getYears()+"\n");
        list.add("C300\t Ivana.B\tWithew\t 1998-07-16\t"+diff4.getYears()+"\n");
        list.add("C250\t Eileen\t Sideways\t 1999-11-27\t"+diff5.getYears()+"\n");
        list.add("C260\t Ima\t Stewpidas\t 2001-01-27\t"+diff5.getYears()+"\n");
        
     /*  list.add("S270\t, Grand Theft Auto\t Toyota\t Mid-size sedan\n");
       list.add("S400\t Prime Motors\t Lexus\t Luxury sedan\n");
       list.add("S300\t We got Cars\t Toyota\t 10-seater minibus\n");
       list.add("S350\t Auto Delight\t BMW\t Luxury SUV\n");
       list.add("S290\t MotorMania\t Hyundai\t compact budget\n");*/


  


        
        Collections.sort(list);
        
       System.out.println("=====================CUSTOMERS============================\nID\t Name\t Surname\t DateOfBirth\t Age\n==========================================================\n"+list+"\nNumber of customers can rant: 4\nNumber of customers cannot rant: 2");
         
    }
    
}
