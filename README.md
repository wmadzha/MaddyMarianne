# MaddyMarianne

An attempt to use MediatR from a CLI template - Domain Driven Design

Assuming we already have a cli engine at our end ( usually our poc product engine ) . And we planning to make use of MediatR/CQRS on our web application. Here are the template that might evolve into something good or maybe something $h!++y . Either way . its a very good learning lesson. 

Milestone 1. 
Come up with a sample CLI engine - Done

Milestone 2.
Build a web app that make use of MediatR. - Done

Milesotne 3.
TBD. 


By using MediatR we can route our handlers based on outcome of specific operations/handlers . In this simple scenario , we are making use of MediatR to perform validation and our business operation. In real complex business modules, MediatR will become handy for us to structurize codes and business logic flow .

MediatR also allow us to have dependency injection being injected to each handler class where specific handler may have a minimal DI services/engines. This also will simplify unit testing to test our code logics 

**Demo flow diagram** 


![alt text](
https://github.com/wmadzha/MaddyMarianne/blob/master/Assets/MediatorDiagram.png?raw=true)


**Special Thanks To**

Jimmy Bogard - MediatR : [View License](https://github.com/jbogard/MediatR/blob/master/LICENSE)

