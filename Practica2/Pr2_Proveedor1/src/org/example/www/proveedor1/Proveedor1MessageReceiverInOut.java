
/**
 * Proveedor1MessageReceiverInOut.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
        package org.example.www.proveedor1;

        /**
        *  Proveedor1MessageReceiverInOut message receiver
        */

        public class Proveedor1MessageReceiverInOut extends org.apache.axis2.receivers.AbstractInOutMessageReceiver{


        public void invokeBusinessLogic(org.apache.axis2.context.MessageContext msgContext, org.apache.axis2.context.MessageContext newMsgContext)
        throws org.apache.axis2.AxisFault{

        try {

        // get the implementation class for the Web Service
        Object obj = getTheImplementationObject(msgContext);

        Proveedor1Skeleton skel = (Proveedor1Skeleton)obj;
        //Out Envelop
        org.apache.axiom.soap.SOAPEnvelope envelope = null;
        //Find the axisOperation that has been set by the Dispatch phase.
        org.apache.axis2.description.AxisOperation op = msgContext.getOperationContext().getAxisOperation();
        if (op == null) {
        throw new org.apache.axis2.AxisFault("Operation is not located, if this is doclit style the SOAP-ACTION should specified via the SOAP Action to use the RawXMLProvider");
        }

        java.lang.String methodName;
        if((op.getName() != null) && ((methodName = org.apache.axis2.util.JavaUtils.xmlNameToJavaIdentifier(op.getName().getLocalPart())) != null)){


        

            if("actualizarStock".equals(methodName)){
                
                org.example.www.proveedor1.ActualizarStockResponse actualizarStockResponse13 = null;
	                        org.example.www.proveedor1.ActualizarStock wrappedParam =
                                                             (org.example.www.proveedor1.ActualizarStock)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.proveedor1.ActualizarStock.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               actualizarStockResponse13 =
                                                   
                                                   
                                                         skel.actualizarStock(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), actualizarStockResponse13, false, new javax.xml.namespace.QName("http://www.example.org/Proveedor1/",
                                                    "actualizarStock"));
                                    } else 

            if("ordenarCompra".equals(methodName)){
                
                org.example.www.proveedor1.OrdenarCompraResponse ordenarCompraResponse15 = null;
	                        org.example.www.proveedor1.OrdenarCompra wrappedParam =
                                                             (org.example.www.proveedor1.OrdenarCompra)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.proveedor1.OrdenarCompra.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               ordenarCompraResponse15 =
                                                   
                                                   
                                                         skel.ordenarCompra(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), ordenarCompraResponse15, false, new javax.xml.namespace.QName("http://www.example.org/Proveedor1/",
                                                    "ordenarCompra"));
                                    } else 

            if("solicitarPresupuesto".equals(methodName)){
                
                org.example.www.proveedor1.SolicitarPresupuestoResponse solicitarPresupuestoResponse17 = null;
	                        org.example.www.proveedor1.SolicitarPresupuesto wrappedParam =
                                                             (org.example.www.proveedor1.SolicitarPresupuesto)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.proveedor1.SolicitarPresupuesto.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               solicitarPresupuestoResponse17 =
                                                   
                                                   
                                                         skel.solicitarPresupuesto(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), solicitarPresupuestoResponse17, false, new javax.xml.namespace.QName("http://www.example.org/Proveedor1/",
                                                    "solicitarPresupuesto"));
                                    
            } else {
              throw new java.lang.RuntimeException("method not found");
            }
        

        newMsgContext.setEnvelope(envelope);
        }
        }
        catch (java.lang.Exception e) {
        throw org.apache.axis2.AxisFault.makeFault(e);
        }
        }
        
        //
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.proveedor1.ActualizarStock param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.proveedor1.ActualizarStock.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.proveedor1.ActualizarStockResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.proveedor1.ActualizarStockResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.proveedor1.OrdenarCompra param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.proveedor1.OrdenarCompra.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.proveedor1.OrdenarCompraResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.proveedor1.OrdenarCompraResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.proveedor1.SolicitarPresupuesto param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.proveedor1.SolicitarPresupuesto.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.proveedor1.SolicitarPresupuestoResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.proveedor1.SolicitarPresupuestoResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.proveedor1.ActualizarStockResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.proveedor1.ActualizarStockResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.proveedor1.ActualizarStockResponse wrapactualizarStock(){
                                org.example.www.proveedor1.ActualizarStockResponse wrappedElement = new org.example.www.proveedor1.ActualizarStockResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.proveedor1.OrdenarCompraResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.proveedor1.OrdenarCompraResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.proveedor1.OrdenarCompraResponse wrapordenarCompra(){
                                org.example.www.proveedor1.OrdenarCompraResponse wrappedElement = new org.example.www.proveedor1.OrdenarCompraResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.proveedor1.SolicitarPresupuestoResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.proveedor1.SolicitarPresupuestoResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.proveedor1.SolicitarPresupuestoResponse wrapsolicitarPresupuesto(){
                                org.example.www.proveedor1.SolicitarPresupuestoResponse wrappedElement = new org.example.www.proveedor1.SolicitarPresupuestoResponse();
                                return wrappedElement;
                         }
                    


        /**
        *  get the default envelope
        */
        private org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory){
        return factory.getDefaultEnvelope();
        }


        private  java.lang.Object fromOM(
        org.apache.axiom.om.OMElement param,
        java.lang.Class type,
        java.util.Map extraNamespaces) throws org.apache.axis2.AxisFault{

        try {
        
                if (org.example.www.proveedor1.ActualizarStock.class.equals(type)){
                
                        return org.example.www.proveedor1.ActualizarStock.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.proveedor1.ActualizarStockResponse.class.equals(type)){
                
                        return org.example.www.proveedor1.ActualizarStockResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.proveedor1.OrdenarCompra.class.equals(type)){
                
                        return org.example.www.proveedor1.OrdenarCompra.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.proveedor1.OrdenarCompraResponse.class.equals(type)){
                
                        return org.example.www.proveedor1.OrdenarCompraResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.proveedor1.SolicitarPresupuesto.class.equals(type)){
                
                        return org.example.www.proveedor1.SolicitarPresupuesto.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.proveedor1.SolicitarPresupuestoResponse.class.equals(type)){
                
                        return org.example.www.proveedor1.SolicitarPresupuestoResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
        } catch (java.lang.Exception e) {
        throw org.apache.axis2.AxisFault.makeFault(e);
        }
           return null;
        }



    

        /**
        *  A utility method that copies the namepaces from the SOAPEnvelope
        */
        private java.util.Map getEnvelopeNamespaces(org.apache.axiom.soap.SOAPEnvelope env){
        java.util.Map returnMap = new java.util.HashMap();
        java.util.Iterator namespaceIterator = env.getAllDeclaredNamespaces();
        while (namespaceIterator.hasNext()) {
        org.apache.axiom.om.OMNamespace ns = (org.apache.axiom.om.OMNamespace) namespaceIterator.next();
        returnMap.put(ns.getPrefix(),ns.getNamespaceURI());
        }
        return returnMap;
        }

        private org.apache.axis2.AxisFault createAxisFault(java.lang.Exception e) {
        org.apache.axis2.AxisFault f;
        Throwable cause = e.getCause();
        if (cause != null) {
            f = new org.apache.axis2.AxisFault(e.getMessage(), cause);
        } else {
            f = new org.apache.axis2.AxisFault(e.getMessage());
        }

        return f;
    }

        }//end of class
    