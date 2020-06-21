﻿
insert into TBSALUD (TIPO_SALUD) values('FONASA')
insert into TBSALUD (TIPO_SALUD) values('ISAPRE')

insert into TBPREVISION  (NOMBRE, COMISION) values ('Cuprum',1.48) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Habitat',1.27) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Modelo',0.77) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Planvital',0.41) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Provida',1.45)


insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (1,'A')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (1,'B')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (1,'C')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (1,'D')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (2,'Cruz Blanca')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (2,'Mas vida ')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (2,'Consalud ')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (2,'MegaSalud')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (2,'Vida tres')
insert into TBSALUD_DETALLE (ID_SALUD,NOMBRE) values (2,'Colmena')

select * from TBSALUD_DETALLE

select * from LIQUIDACIONJOSEGONZALEZ

select * from TBPREVISION

update LIQUIDACIONJOSEGONZALEZ set ID_SALUD = SALUD 
alter table LIQUIDACIONJOSEGONZALEZ drop column SALUD


insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('15211982-8','ALMONACID ULLOA PATRICIO ALFREDO','enero',2020,25,276000,1,2,1,3,'SI')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('14401452-9','ANDREWS XANDRE CHRISTOPHER','enero',2020,24,280000,2,1,2,6,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('9021341-5','ARMIJO MORALES FRANCISCO JAVIER','enero',2020,23,152000,0,3,1,2,'SI')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('24630384-3','BERRÍOS ROBLES CARLOS ALFRED','enero',2020,25,360000,0,5,1,2,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('18670708-7','CARRASCO MONSÁLVEZ FREDDY HERNÁN','enero',2020,22,240000,0,4,2,7,'SI')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('10336154-0','CERDA ROSALES CRISTOPHER HERNAN','enero',2020,21,180000,0,1,1,3,'SI')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('12041682-0','DIAZ CUBA CINTIA AMANDA','enero',2020,42,120000,2,3,2,8,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('14122649-5','DURAN VALENCIA JOSE LUIS','enero',2020,32,350000,3,6,1,1,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('18247430-4','GONZÁLEZ RIQUELME JOSÉ ROBERTO','enero',2020,21,780000,1,5,2,10,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('13693435-k','HERNÁNDEZ ESPINOZA CARLOS ANDRÉS','enero',2020,54,246666,1,4,2,9,'SI')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('15500101-1','IBAÑEZ GUTIERREZ CARLOS ARIEL','enero',2020,21,253000,2,2,2,8,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('22963434-8','INOSTROZA LOYOLA JEAN PAUL','enero',2020,21,286000,0,4,1,2,'SI')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('24629427-5','JOSEPH STEEVENSON','enero',2020,4,152000,0,2,1,3,'NO')
insert into LIQUIDACIONJoseGonzalez (RUT,NOMBRE,MES,ANIO,EDAD,SUELDO_BASE,CARGAS, AFP,SALUD,SALUD_DETALLE,COTIZACION_VOLUNTARIA) values('18483270-4','POBLETE MERY CAMILA PAZ','enero',2020,21,120000,0,1,1,1,'SI')