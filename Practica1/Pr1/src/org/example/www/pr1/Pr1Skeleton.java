
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
		// TODO : fill this with the necessary business logic
		throw new java.lang.UnsupportedOperationException(
				"Please implement " + this.getClass().getName() + "#generarPresupuesto");
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param validarIBAN
	 * @return validarIBANResponse
	 */

	public org.example.www.pr1.ValidarIBANResponse validarIBAN(org.example.www.pr1.ValidarIBAN validarIBAN) {
		// TODO : fill this with the necessary business logic
		throw new java.lang.UnsupportedOperationException(
				"Please implement " + this.getClass().getName() + "#validarIBAN");
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param solicitarPresupuesto
	 * @return solicitarPresupuestoResponse
	 */

	public org.example.www.pr1.SolicitarPresupuestoResponse solicitarPresupuesto(
			org.example.www.pr1.SolicitarPresupuesto solicitarPresupuesto) {
		// TODO : fill this with the necessary business logic
		throw new java.lang.UnsupportedOperationException(
				"Please implement " + this.getClass().getName() + "#solicitarPresupuesto");
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

}
    