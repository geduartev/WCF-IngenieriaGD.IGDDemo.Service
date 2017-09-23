# V.1.0.0 Gabriel Eduardo Duarte Vega - 2017/09/22
## Servicio Web WCF (Soap)
### Librería, Host: Aplicación Windows de Consola, Sitio Web y Servicio de Windows
> Descripción: Solución con varios proyectos que representan la librería con las 
> operaciones del servicio, hosts y clientes para publicar, escuchar y responder 
> a solicitudes por diferentes canales.
+ EvalServiceLibrary: librería con operaciones del servicio.
+ ClientEvalService: proyecto consola prueba para emular un cliente que consume un servicio WCF.
+ EvalServiceHost: aplicación windows de consola con el servicio WCF que escucha y responde las solicitudes.
+ EvalServiceSite: sitio web que expone el servicio WCF para ser consumido.
+ EvalWindowsService: servicio de Windows que expone el servicio.

# V.1.0.1 Gabriel Eduardo Duarte Vega - 2017/09/23
## Servicio Web CF (Soap - Rest)
### Independizar configuraciones del servicio web y hacer que ahora sea SOAP y Rest
+ Se retira la dependencia en la aplicación de consola Host WCF para que no se tengan que administrar configuraciones estas solo quedan en la interface.
+ TODO: Se sugiere propone que la interface no almacene en código o queme nombres de canales o configuraciones.
+ TODO: el javascript del evento OnClick en un botón no funciona hay que revisar.
+ TODO: el botón delegado no carga la data adecuadamente en el proyecto Cliente.