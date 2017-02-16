
/**
 * Pr1Skeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.pr1;
import org.example.www.pr1.MySQL;


/**
 * Pr1Skeleton java skeleton for the axisService
 */
public class Pr1Skeleton {

	/**
	 * Auto generated method signature
	 * 
	 * @param generarPresupuesto
	 * @return generarPresupuestoResponse
	 */
	private String user = "root";
	private String pass = "";
	private String db_name = "interpolaridad";

	public org.example.www.pr1.GenerarPresupuestoResponse generarPresupuesto(
			org.example.www.pr1.GenerarPresupuesto generarPresupuesto) {
		GenerarPresupuestoResponse presu = new GenerarPresupuestoResponse();
		try{
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if(conectar.comparegetKey(generarPresupuesto.getSoapKey())==true){
				try{
					conectar.insertarPresupuesto(generarPresupuesto);
					presu.setIdPresupuesto(conectar.devolverID(generarPresupuesto));
					presu.setPresupuestoGeneradoCorrectamente(true);
				}catch(Exception es){
					presu.setPresupuestoGeneradoCorrectamente(false);
				}	
			}else{
				presu.setPresupuestoGeneradoCorrectamente(false);
			}
		}catch(Exception ex){
			presu.setPresupuestoGeneradoCorrectamente(false);
		}
				return presu;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param validarIBAN
	 * @return validarIBANResponse
	 */

	public org.example.www.pr1.ValidarIBANResponse validarIBAN(org.example.www.pr1.ValidarIBAN validarIBAN) {
		ValidarIBANResponse iban = new ValidarIBANResponse();
		try{
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if(conectar.comparegetKey(validarIBAN.getSoapKey())==true){
				Boolean resul = comprobarIBAN(validarIBAN.getIban());
				if (resul==true) {
					iban.setMsg("Iban correcto");
					iban.setOut(true);
				} else {
					iban.setMsg("Iban incorrecto");
					iban.setOut(false);
				}
			}else{
				iban.setMsg("Key erronea");
				iban.setOut(false);
			}
		}catch(Exception ex){
			iban.setMsg("Error");
			iban.setOut(false);
		}
		return iban;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param solicitarPresupuesto
	 * @return solicitarPresupuestoResponse
	 */

	public org.example.www.pr1.SolicitarPresupuestoResponse solicitarPresupuesto(
			org.example.www.pr1.SolicitarPresupuesto solicitarPresupuesto) {
		SolicitarPresupuestoResponse soli = new SolicitarPresupuestoResponse();
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if(conectar.comparegetKey(solicitarPresupuesto.getSoapKey())==true){
				soli = conectar.consultarPieza(solicitarPresupuesto);
			}
			
			return soli;
		
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param validarNIF
	 * @return validarNIFResponse
	 */

	public org.example.www.pr1.ValidarNIFResponse validarNIF(org.example.www.pr1.ValidarNIF validarNIF) {
		
		ValidarNIFResponse nif = new ValidarNIFResponse();
		//MySQL conectar = new MySQL();
		
		try{
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if(conectar.comparegetKey(validarNIF.getSoapKey())==true){
				if(validarNIF.getNif().length()!=9){
					nif.setOut("Tamaño incorrecto");
				}else{
					int dni;
					String cadena="";
					char letra = 0;
					for(int i=0;i<9;i++){					
						if(i==8){
							letra = validarNIF.getNif().toUpperCase().charAt(i);
						}else{
							cadena= cadena + validarNIF.getNif().charAt(i);
						}
					}
					dni= Integer.parseInt(cadena);
					String letras="TRWAGMYFPDXBNJZSQVHLCKE";
				    int modulo= dni % 23;
				    char resul = letras.charAt(modulo);
				    if(resul==letra){
				    	nif.setOut("Correcto!");
				    }else{
				    	nif.setOut("Incorrecto!");
				    }
				}
			}else{
					nif.setOut("Key incorrecta");
			}
			
		}catch(Exception ex){
			nif.setOut("No se pudo conectar");
		}
		
		
		return nif;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param consultaCodigoPostal
	 * @return consultaCodigoPostalResponse
	 */

	public org.example.www.pr1.ConsultaCodigoPostalResponse consultaCodigoPostal(
			org.example.www.pr1.ConsultaCodigoPostal consultaCodigoPostal) {
		ConsultaCodigoPostalResponse datos = new ConsultaCodigoPostalResponse();
		try{
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if(conectar.comparegetKey(consultaCodigoPostal.getSoapKey())==true){
				return conectar.devolverCodPos(consultaCodigoPostal.getCodpos());
			}else{
				datos.setCodigoPostal(consultaCodigoPostal.getCodpos());
				datos.setPoblacion("Key incorrecta!");
				datos.setProvincia("Key incorrecta!");
				return datos;
			}
		}catch(Exception ex){
			datos.setCodigoPostal(consultaCodigoPostal.getCodpos());
			datos.setPoblacion("ERROR!");
			datos.setProvincia("ERROR!");
			return datos;
		}	
	}
	
	
	public Boolean comprobarIBAN(String iban) throws Exception {
		Boolean rs = destriparIban(iban);
		if (!rs) {
			return false;
		} else {
			return true;
		}
	}
	
    public static Boolean destriparIban(String iban) throws Exception {
        if (iban.length() == 24) {
            return validarCuentaES(iban.substring(4, 24));
        } else {
        	return false;
        }
    }
    
    public static Boolean validarCuentaES(String ccc) throws Exception {
        try {
            String banco = ccc.substring(0, 4);
            String oficina = ccc.substring(4, 8);
            String dc = ccc.substring(8, 10);
            String cuenta = ccc.substring(10, 20);
            if (!dc.equals(ObtenerDC(banco, oficina, cuenta))) {
                return false;
            } else if ("0000".equals(banco) || "0000".equals(oficina) || "0000000000".equals(cuenta)) {
                return false;
            } else {
                return true;
            }
        } catch (StringIndexOutOfBoundsException e) {
            System.err.println(e.getMessage());
            return false;
        }
    }
    
    public static String ObtenerDC(String banco, String oficina, String cuenta) throws StringIndexOutOfBoundsException {
        int temp;
        String dg1, dg2;
        temp = 0;

        temp += Integer.parseInt(banco.substring(0, 1)) * 4;
        temp += Integer.parseInt(banco.substring(1, 2)) * 8;
        temp += Integer.parseInt(banco.substring(2, 3)) * 5;
        temp += Integer.parseInt(banco.substring(3, 4)) * 10;
        temp += Integer.parseInt(oficina.substring(0, 1)) * 9;
        temp += Integer.parseInt(oficina.substring(1, 2)) * 7;
        temp += Integer.parseInt(oficina.substring(2, 3)) * 3;
        temp += Integer.parseInt(oficina.substring(3, 4)) * 6;

        temp = 11 - temp % 11;
        switch (temp) {
            case 10:
                dg1 = String.valueOf(1);
                break;
            case 11:
                dg1 = String.valueOf(0);
                break;
            default:
                dg1 = String.valueOf(temp);
                break;
        }
        temp = 0;

        temp += Integer.parseInt(cuenta.substring(0, 1)) * 1;
        temp += Integer.parseInt(cuenta.substring(1, 2)) * 2;
        temp += Integer.parseInt(cuenta.substring(2, 3)) * 4;
        temp += Integer.parseInt(cuenta.substring(3, 4)) * 8;
        temp += Integer.parseInt(cuenta.substring(4, 5)) * 5;
        temp += Integer.parseInt(cuenta.substring(5, 6)) * 10;
        temp += Integer.parseInt(cuenta.substring(6, 7)) * 9;
        temp += Integer.parseInt(cuenta.substring(7, 8)) * 7;
        temp += Integer.parseInt(cuenta.substring(8, 9)) * 3;
        temp += Integer.parseInt(cuenta.substring(9, 10)) * 6;

        temp = 11 - temp % 11;
        switch (temp) {
            case 10:
                dg2 = String.valueOf(1);
                break;
            case 11:
                dg2 = String.valueOf(0);
                break;
            default:
                dg2 = String.valueOf(temp);
                break;
        }
        return String.valueOf(dg1) + String.valueOf(dg2);
    }

}
    