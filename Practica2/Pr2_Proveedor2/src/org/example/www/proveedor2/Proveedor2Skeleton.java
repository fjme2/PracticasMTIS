
/**
 * Proveedor2Skeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
package org.example.www.proveedor2;

/**
 * Proveedor2Skeleton java skeleton for the axisService
 */
public class Proveedor2Skeleton {

	/**
	 * Auto generated method signature
	 * 
	 * @param actualizarStock
	 * @return actualizarStockResponse
	 */


	private String user = "root";
	private String pass = "";
	private String db_name = "proveedor2";

	public org.example.www.proveedor2.ActualizarStockResponse actualizarStock(
			org.example.www.proveedor2.ActualizarStock actualizarStock) {
		ActualizarStockResponse actu = new ActualizarStockResponse();
		try {
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			if (conectar.actualizarStock(actualizarStock.getReferenciaProducto(),
					actualizarStock.getNumeroUnidades())) {
				actu.setActualiza(true);
			}
		} catch (Exception ex) {
			actu.setActualiza(false);
			return actu;
		}
		return actu;
		
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param ordenarCompra
	 * @return ordenarCompraResponse
	 */

	public org.example.www.proveedor2.OrdenarCompraResponse ordenarCompra(
			org.example.www.proveedor2.OrdenarCompra ordenarCompra) {
		
		OrdenarCompraResponse orde = new OrdenarCompraResponse();
		orde.setOrdenado(true);
		return orde;
	}

	/**
	 * Auto generated method signature
	 * 
	 * @param solicitarPresupuesto
	 * @return solicitarPresupuestoResponse
	 */

	public org.example.www.proveedor2.SolicitarPresupuestoResponse solicitarPresupuesto(
			org.example.www.proveedor2.SolicitarPresupuesto solicitarPresupuesto) {
		SolicitarPresupuestoResponse presu = new SolicitarPresupuestoResponse();
		
		try {
			MySQL conectar = new MySQL();
			conectar.MySQLConnection(user, pass, db_name);
			presu.setPrecio(conectar.getPrecio(solicitarPresupuesto.getReferenciaProducto()));
		}catch(Exception ex){
			presu.setPrecio(0);
			return presu;
		}
		
		return presu;
	}

}
