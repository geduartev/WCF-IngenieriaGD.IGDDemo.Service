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