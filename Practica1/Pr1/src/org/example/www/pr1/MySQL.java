package org.example.www.pr1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.Objects;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
 
public class MySQL {
 
    private static Connection Conexion;

 
    public void MySQLConnection(String user, String pass, String db_name) {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/" + db_name, user, pass);
            System.out.println("Se ha iniciado la conexión con el servidor de forma exitosa");
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(MySQL.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(MySQL.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
 
    public void closeConnection() {
        try {
            Conexion.close();
            System.out.println("Se ha finalizado la conexión con el servidor");
        } catch (SQLException ex) {
            Logger.getLogger(MySQL.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
 
    public void createDB(String name) {
        try {
            String Query = "CREATE DATABASE " + name;
            Statement st = Conexion.createStatement();
            st.executeUpdate(Query);
            MySQLConnection("root", "", name);
            JOptionPane.showMessageDialog(null, "Se ha creado la base de datos " + name + " de forma exitosa");
        } catch (SQLException ex) {
            Logger.getLogger(MySQL.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
 
    public void createTable(String name) {
        try {
            String Query = "CREATE TABLE " + name + ""
                    + "(ID VARCHAR(25),Nombre VARCHAR(50), Apellido VARCHAR(50),"
                    + " Edad VARCHAR(3), Sexo VARCHAR(1))";
            JOptionPane.showMessageDialog(null, "Se ha creado la base de tabla " + name + " de forma exitosa");
            Statement st = Conexion.createStatement();
            st.executeUpdate(Query);
        } catch (SQLException ex) {
            Logger.getLogger(MySQL.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
 
    public void insertData(String table_name, String ID, String name, String lastname, String age, String gender) {
        try {
            String Query = "INSERT INTO " + table_name + " VALUES("
                    + "\"" + ID + "\", "
                    + "\"" + name + "\", "
                    + "\"" + lastname + "\", "
                    + "\"" + age + "\", "
                    + "\"" + gender + "\")";
            Statement st = Conexion.createStatement();
            st.executeUpdate(Query);
            JOptionPane.showMessageDialog(null, "Datos almacenados de forma exitosa");
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Error en el almacenamiento de datos");
        }
    }
 
    public void getValues(String table_name) {
        try {
            String Query = "SELECT * FROM " + table_name;
            Statement st = Conexion.createStatement();
            java.sql.ResultSet resultSet;
            resultSet = st.executeQuery(Query);
 
            while (resultSet.next()) {
                System.out.println("ID: " + resultSet.getString("ID") + " "
                        + "Nombre: " + resultSet.getString("Nombre") + " " + resultSet.getString("Apellido") + " "
                        + "Edad: " + resultSet.getString("Edad") + " "
                        + "Sexo: " + resultSet.getString("Sexo"));
            }
 
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Error en la adquisición de datos");
        }
    }
 
    public void deleteRecord(String table_name, String ID) {
        try {
            String Query = "DELETE FROM " + table_name + " WHERE ID = \"" + ID + "\"";
            Statement st = Conexion.createStatement();
            st.executeUpdate(Query);
 
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
            JOptionPane.showMessageDialog(null, "Error borrando el registro especificado");
        }
    }
    
  //compara la key pasada con las que hay en la BD
    public boolean comparegetKey(String key){
    	boolean encontrado=false;
    	try {
    		String Query = "SELECT * FROM skey";
    		Statement st = Conexion.createStatement();
    		java.sql.ResultSet resultSet;
    		resultSet = st.executeQuery(Query);

    		while (resultSet.next() && encontrado==false) {
    			System.out.println("SoapKey: " + resultSet.getString("SoapKey"));
    			System.out.println("Key: " + key);
    			
    			encontrado= Objects.equals(key, resultSet.getString("SoapKey"));
    		}

    	}catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, "Error en la adquisición de datos");
        }
    	return encontrado;
    }
    
    public ConsultaCodigoPostalResponse devolverCodPos(String codpos){
    	ConsultaCodigoPostalResponse resul = new ConsultaCodigoPostalResponse();
    	String valor="";
    	boolean encontrado=false;
    	try {
    		String Query = "SELECT * FROM codigospostales";
    		Statement st = Conexion.createStatement();
    		java.sql.ResultSet resultSet;
    		resultSet = st.executeQuery(Query);
    		
    		while (resultSet.next() && encontrado==false) {
    			if(Objects.equals(codpos,resultSet.getString("codigoPostal"))){
    				resul.setCodigoPostal(codpos);
    	    		resul.setPoblacion(resultSet.getString("poblacion"));
    	    		resul.setProvincia(resultSet.getString("provincia"));
    	    		encontrado= true;
    			}
    		}
    		
    		

    	}catch (SQLException ex) {
    		JOptionPane.showMessageDialog(null, "Error en la adquisición de datos");
        }
    	
    	return resul;
    }
    
    public void insertarPresupuesto(org.example.www.pr1.GenerarPresupuesto generarPresupuesto){
    	String DATE_FORMAT = "yyyy-MM-dd";
		SimpleDateFormat sdf = new SimpleDateFormat(DATE_FORMAT);
		String fechaFormateada = sdf.format(generarPresupuesto.getFechaPresupuesto());
    	String Query = "INSERT INTO presupuestos (fechaPresupuesto,idcliente,referenciaProducto,"
    			+ "cantidadProducto) VALUES("
    	       		 + "\"" + fechaFormateada + "\", "
    	                + generarPresupuesto.getId() + ", "
    	                + "\"" + generarPresupuesto.getReferenciaProducto() + "\", "
    	                + generarPresupuesto.getCantidadProducto() + ")";
    	 try {   
             Statement st = Conexion.createStatement();
             st.executeUpdate(Query);
             JOptionPane.showMessageDialog(null, "Datos almacenados de forma exitosa");
         } catch (SQLException ex) {
        	 JOptionPane.showMessageDialog(null, ex);
             JOptionPane.showMessageDialog(null, "Error en el almacenamiento de datos");

         }
    }
    
    public int devolverID(org.example.www.pr1.GenerarPresupuesto generarPresupuesto){
    	int id=0;
    	String valor="";
    	try {
    		String Query = "SELECT id FROM presupuestos";
    		Statement st = Conexion.createStatement();
    		java.sql.ResultSet resultSet;
    		resultSet = st.executeQuery(Query);
    		
    		while (resultSet.next()) {
    			id=resultSet.getInt("id");
    		}
    		
    	}catch (SQLException ex) {
    		JOptionPane.showMessageDialog(null, "Error en la adquisición de datos");
        }

    	return id;
    }
    
    public SolicitarPresupuestoResponse consultarPieza(org.example.www.pr1.SolicitarPresupuesto solicitarPresupuesto){
    	SolicitarPresupuestoResponse soli = new SolicitarPresupuestoResponse();
    	try {
    		String Query = "SELECT * FROM piezas where referencia= \""
    				+ solicitarPresupuesto.getReferenciaPieza() + "\" and "
    						+ "proveedor =" + solicitarPresupuesto.getIdProveedor();
    		Statement st = Conexion.createStatement();
    		java.sql.ResultSet resultSet;
    		resultSet = st.executeQuery(Query);
    		
    		while (resultSet.next()) {
    			soli.setDisponibilidadPieza(resultSet.getBoolean("disponibilidad"));
    			soli.setFechaDisponibilidadPieza(resultSet.getDate("fechaDisp"));
    			soli.setPrecioPieza(resultSet.getFloat("precio"));
    		}
    		
    	}catch (SQLException ex) {
    		JOptionPane.showMessageDialog(null, "Error en la adquisición de datos");
        }
    	
    	return soli;
    }
 
}
