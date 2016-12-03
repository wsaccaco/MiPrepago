USE BD_MiPrepago
GO

alter table modelo
add fec_fab date
go

alter table modelo
alter column modelo_id int not null  
go


insert into marca values(1, 'Sony');
insert into marca values(2, 'Samsung');
insert into marca values(3, 'Apple');

insert into marca values (5,'Otros')
GO

insert into modelo values(1, 'xperia 8', 1, '2016-05-10')
insert into modelo values(2, 'xperia 7', 1, '2015-05-10')
insert into modelo values(3, 'Z1', 1 ,'2014-05-10')

insert into modelo values(4, 'S6', 2 ,'2016-05-10')
insert into modelo values(5, 'S5 mini', 2 ,'2015-05-10')
insert into modelo values(6, 'Galaxy II', 2 ,'2014-05-10')

insert into modelo values(7, 'iPhone5', 3,'2016-05-10')
insert into modelo values(8, 'iPhone5S', 3,'2015-05-10')
insert into modelo values(9, 'iPhone6', 3,'2014-05-10')
GO

insert into proveedor values(1, 'claro', 'http://localhost:12855/Modelos.svc/modelo/', 'json');
GO


USE BD_PROVEEDOR
GO

insert into marca values(1, 'Sony');
insert into marca values(2, 'Samsung');
insert into marca values(3, 'Apple');
insert into marca values(4, 'Motorola');
insert into marca values(5, 'Xiaomi');
GO

insert into modelo values(1, 'xperia 8', '20150101', 120.00, 12, 1)
insert into modelo values(2, 'xperia 7', '20150101', 80.00, 10, 1)
insert into modelo values(3, 'Z1', '20150101', 1200.00, 40, 1)

insert into modelo values(4, 'S6', '20150101', 700.00, 20, 2)
insert into modelo values(5, 'S5 mini', '20150101', 1220.00, 10, 2)
insert into modelo values(6, 'Galaxy II', '20150101', 2020.00, 2, 2)

insert into modelo values(7, 'iPhone5', '20150101', 900.00, 10, 3)
insert into modelo values(8, 'iPhone5S', '20150101', 2220.00, 6, 3)
insert into modelo values(9, 'iPhone6', '20150101', 1000.00, 22, 3)

insert into modelo values(10, 'MiNote', '20150101', 1900.00, 4, 5)
insert into modelo values(11, 'Mi4', '20150101', 1220.00, 2, 5)
insert into modelo values(12, 'Mi4i', '20140101', 2000.00, 12, 5)
GO