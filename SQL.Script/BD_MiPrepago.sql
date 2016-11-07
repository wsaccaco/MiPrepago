-- Generado por Oracle SQL Developer Data Modeler 4.2.0.917
--   en:        2016-11-07 00:53:58 COT
--   sitio:      SQL Server 2012
--   tipo:      SQL Server 2012

CREATE DATABASE BD_MiPrepago
go

USE BD_MiPrepago
GO


CREATE TABLE marca 
    (
     marca_id INTEGER NOT NULL , 
     nombre VARCHAR (90) 
    )
/*** Error de sintaxis en la línea 7, columna 6


    )
      ^^^

Se esperaba: name_wo_function_call,identifier,name,sim_stmt,fun
 ***/
    ON "default"
GO

ALTER TABLE marca ADD CONSTRAINT marca_PK PRIMARY KEY
/*** Error de sintaxis en la línea 1, columna 58


    ALTER TABLE marca ADD CONSTRAINT marca_PK PRIMARY KEY CLUSTERED (marca_id)
                                                          ^^^                   

Se esperaba: 
 ***/ CLUSTERED (marca_id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE modelo 
    (
     modelo_id INTEGER NOT NULL , 
     nombre VARCHAR (90) , 
     marca_marca_id INTEGER NOT NULL 
    )
/*** Error de sintaxis en la línea 8, columna 6


    )
      ^^^

Se esperaba: name_wo_function_call,identifier,name,sim_stmt,fun
 ***/
    ON "default"
GO

ALTER TABLE modelo ADD CONSTRAINT modelo_PK PRIMARY KEY
/*** Error de sintaxis en la línea 1, columna 60


    ALTER TABLE modelo ADD CONSTRAINT modelo_PK PRIMARY KEY CLUSTERED (modelo_id)
                                                            ^^^                    

Se esperaba: 
 ***/ CLUSTERED (modelo_id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE proveedor 
    (
     proveedor_id INTEGER NOT NULL , 
     nombre VARCHAR (90) , 
     ruta_servicio VARCHAR (250) , 
     tipo_servicio VARCHAR (40) 
    )
/*** Error de sintaxis en la línea 9, columna 6


    )
      ^^^

Se esperaba: name_wo_function_call,identifier,name,sim_stmt,fun
 ***/
    ON "default"
GO

ALTER TABLE proveedor ADD CONSTRAINT proveedor_PK PRIMARY KEY
/*** Error de sintaxis en la línea 1, columna 66


    ALTER TABLE proveedor ADD CONSTRAINT proveedor_PK PRIMARY KEY CLUSTERED (proveedor_id)
                                                                  ^^^                       

Se esperaba: 
 ***/ CLUSTERED (proveedor_id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE reserva 
    (
     reserva_id INTEGER NOT NULL , 
     nombre VARCHAR (90) , 
     apellidos VARCHAR (90) , 
     email VARCHAR (90) , 
     celular VARCHAR (9) , 
     cantidad INTEGER , 
     fecha DATETIME , 
     proveedor_id INTEGER NOT NULL 
    )
/*** Error de sintaxis en la línea 13, columna 6


    )
      ^^^

Se esperaba: name_wo_function_call,identifier,name,sim_stmt,fun
 ***/
    ON "default"
GO

ALTER TABLE reserva ADD CONSTRAINT reserva_PK PRIMARY KEY
/*** Error de sintaxis en la línea 1, columna 62


    ALTER TABLE reserva ADD CONSTRAINT reserva_PK PRIMARY KEY CLUSTERED (reserva_id)
                                                              ^^^                     

Se esperaba: 
 ***/ CLUSTERED (reserva_id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

ALTER TABLE modelo 
    ADD CONSTRAINT modelo_marca_FK FOREIGN KEY 
    ( 
     marca_marca_id
    ) 
    REFERENCES marca 
    ( 
     marca_id 
    ) 
    ON
/*** Error de sintaxis en la línea 11, columna 7


    ON DELETE NO ACTION 
       ^^^                

Se esperaba: 'DELETE',
 ***/ DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE reserva 
    ADD CONSTRAINT reserva_proveedor_FK FOREIGN KEY 
    ( 
     proveedor_id
    ) 
    REFERENCES proveedor 
    ( 
     proveedor_id 
    ) 
    ON
/*** Error de sintaxis en la línea 11, columna 7


    ON DELETE NO ACTION 
       ^^^                

Se esperaba: 'DELETE',
 ***/ DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO