/*==============================================================*/
/* DBMS name:      SAP SQL Anywhere 17                          */
/* Created on:     21-06-2020 12:56:58                          */
/*==============================================================*/


drop table if exists LIQUIDACIONJOSEGONZALEZ;

drop table if exists TBPREVISION;

drop table if exists TBSALUD;

drop table if exists TBSALUD_DETALLE;

/*==============================================================*/
/* Table: LIQUIDACIONJOSEGONZALEZ                               */
/*==============================================================*/
create table LIQUIDACIONJOSEGONZALEZ 
(
   ID_TRABAJDOR         int                            not null identity(1,1),
   ID_SALUD             int                            null,
   RUT                  varchar(12)                    null,
   NOMBRE               varchar(50)                    null,
   MES                  varchar(20)                    null,
   ANIO                 int                            null,
   SUELDO_BASE          int                            null,
   CARGAS               int                             null,
   EDAD                 int                            null, 
   AFP                  int                            null,
   SALUD                int                            null,
   SALUD_DETALLE        int                            null,
   COTIZACION_VOLUNTARIA varchar(10)                    null
);

alter table LIQUIDACIONJOSEGONZALEZ
   add constraint FK_LIQUIDAC_REFERENCE_TBSALUD foreign key (ID_SALUD)
      references TBSALUD (ID_SALUD)


/*==============================================================*/
/* Table: TBPREVISION                                           */
/*==============================================================*/
create table TBPREVISION 
(
   ID                   int          identity(1,1)     not null,
   NOMBRE               varchar(50)                    null,
   COMISION             float                          null
);

/*==============================================================*/
/* Table: TBSALUD                                               */
/*==============================================================*/
create table TBSALUD 
(
   ID_SALUD             int      identity(1,1)         not null,
   TIPO_SALUD           varchar(20)                    null,
   constraint PK_TBSALUD primary key clustered (ID_SALUD)
);

/*==============================================================*/
/* Table: TBSALUD_DETALLE                                       */
/*==============================================================*/
create table TBSALUD_DETALLE 
(
   ID_TBSALUD_DETALLE   int           identity(1,1)                 not null,
   ID_SALUD             int                            null,
   NOMBRE               varchar(20)                    null,
   constraint PK_TBSALUD_DETALLE primary key clustered (ID_TBSALUD_DETALLE)
);


alter table TBSALUD_DETALLE
   add constraint FK_TBSALUD__REFERENCE_TBSALUD foreign key (ID_SALUD)
      references TBSALUD (ID_SALUD)


