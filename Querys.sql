
select * from LIQUIDACIONJoseGonzalez

select * from TBSALUD

select * from LIQUIDACIONJoseGonzalez where RUT = '18247430-4'

select * from TBPREVISION

select MAX(SALUD_DETALLE) from LIQUIDACIONJOSEGONZALEZ

select * from TBSALUD_DETALLE

insert into TBSALUD (TIPO_SALUD) values('FONASA')
insert into TBSALUD (TIPO_SALUD) values('ISAPRE')

insert into TBPREVISION  (NOMBRE, COMISION) values ('Cuprum',1.48) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Habitat',1.27) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Modelo',0.77) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Planvital',0.41) 
insert into TBPREVISION  (NOMBRE, COMISION) values ('Provida',1.45)

update LIQUIDACIONJoseGonzalez set ID_SALUD = SALUD 

alter table LIQUIDACIONJoseGonzalez drop column SALUD


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
