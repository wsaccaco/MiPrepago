-- Generado por Oracle SQL Developer Data Modeler 4.2.0.917
--   en:        2016-11-14 22:29:59 COT
--   sitio:      SQL Server 2012
--   tipo:      SQL Server 2012

CREATE DATABASE BD_PROVEEDOR
GO

USE BD_PROVEEDOR
GO


CREATE TABLE marca 
    (
     id INTEGER NOT NULL , 
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


    ALTER TABLE marca ADD CONSTRAINT marca_PK PRIMARY KEY CLUSTERED (id)
                                                          ^^^             

Se esperaba: 
 ***/ CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE modelo 
    (
     id INTEGER NOT NULL , 
     nombre VARCHAR (90) , 
     anio DATE , 
     precio FLOAT (6) , 
     stock INTEGER , 
     marca_id INTEGER NOT NULL 
    )
/*** Error de sintaxis en la línea 11, columna 6


    )
      ^^^

Se esperaba: name_wo_function_call,identifier,name,sim_stmt,fun
 ***/
    ON "default"
GO

ALTER TABLE modelo ADD CONSTRAINT modelo_PK PRIMARY KEY
/*** Error de sintaxis en la línea 1, columna 60


    ALTER TABLE modelo ADD CONSTRAINT modelo_PK PRIMARY KEY CLUSTERED (id)
                                                            ^^^             

Se esperaba: 
 ***/ CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE ventas 
    (
     id INTEGER NOT NULL Identity(1, 1), 
     estado VARCHAR (20) , 
     cantidad INTEGER , 
     fecha DATETIME , 
     codigo_reserva VARCHAR (32) , 
     modelo_id INTEGER NOT NULL 
    )
/*** Error de sintaxis en la línea 11, columna 6


    )
      ^^^

Se esperaba: name_wo_function_call,identifier,name,sim_stmt,fun
 ***/
    ON "default"
GO

ALTER TABLE ventas ADD CONSTRAINT ventas_PK PRIMARY KEY
/*** Error de sintaxis en la línea 1, columna 60


    ALTER TABLE ventas ADD CONSTRAINT ventas_PK PRIMARY KEY CLUSTERED (id)
                                                            ^^^             

Se esperaba: 
 ***/ CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

ALTER TABLE modelo 
    ADD CONSTRAINT modelo_marca_FK FOREIGN KEY 
    ( 
     marca_id
    ) 
    REFERENCES marca 
    ( 
     id 
    ) 
    ON
/*** Error de sintaxis en la línea 11, columna 7


    ON DELETE NO ACTION 
       ^^^                

Se esperaba: 'DELETE',
 ***/ DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE ventas 
    ADD CONSTRAINT ventas_modelo_FK FOREIGN KEY 
    ( 
     modelo_id
    ) 
    REFERENCES modelo 
    ( 
     id 
    ) 
    ON
/*** Error de sintaxis en la línea 11, columna 7


    ON DELETE NO ACTION 
       ^^^                

Se esperaba: 'DELETE',
 ***/ DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO