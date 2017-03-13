
/**
 * AlmacenSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.almacen;

/**
 * AlmacenSkeleton java skeleton for the axisService
 */
public class AlmacenSkeleton {

	/**
	 * Comprueba el stock que tiene el almacen
	 * 
	 * @param comprobarStock
	 * @return comprobarStockResponse
	 */

	private String user = "root";
	private String pass = "";
	private String db_name = "almacen";

	public org.example.www.almacen.ComprobarStockResponse comprobarStock(
			org.example.www.almacen.ComprobarStock comprobarStock) {
		ComprobarStockResponse venta = new ComprobarStockResponse();
		try {
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			int stock = conectar.devolverStock(comprobarStock.getReferenciaProducto()) - comprobarStock.getNumeroUnidades();
			if ( stock > 0) {			
				venta.setFunca(true);
				venta.setMensaje("Venta aceptada");
			}else{
				venta.setFunca(false);
				venta.setMensaje("Error");
			}
		} catch (Exception ex) {
			venta.setFunca(false);
			venta.setMensaje("Error");
			return venta;
		}

		return venta;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param actualizarStock
	 * @return actualizarStockResponse
	 */

	public org.example.www.almacen.ActualizarStockResponse actualizarStock(
			org.example.www.almacen.ActualizarStock actualizarStock) {
		ActualizarStockResponse actu = new ActualizarStockResponse();
		try {
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if (conectar.actualizarStock(actualizarStock.getReferenciaProducto(), actualizarStock.getNumeroUnidades())) {
				actu.setFunca(true);
				actu.setMensaje("Producto actualizado");
			}
		} catch (Exception ex) {
			actu.setFunca(false);
			actu.setMensaje("Error al actualizar datos");
			return actu;
		}
		return actu;
	}

}
