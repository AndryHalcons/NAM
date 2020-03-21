






/* --------------Creacion Esquema--------------- */
CREATE SCHEMA `npms`;





/* --------------Creacion tabla logs IPv6--------------- */

 CREATE TABLE `log_ip_ipv6` (
  `ID` INT(20) NOT NULL AUTO_INCREMENT,
  `IP` varchar(30) NOT NULL,
  `Accion` varchar(45) DEFAULT NULL,
  `Vlan` int(11) NOT NULL,
  `Ubicacion` varchar(150) DEFAULT NULL,
  `Mac` varchar(40) DEFAULT NULL,
  `DNS` varchar(150) DEFAULT NULL,
  `Descripcion` varchar(150) DEFAULT NULL,
  `Hostname_revisado` varchar(150) DEFAULT NULL,
  `Hostname` varchar(150) DEFAULT NULL,
  `Fecha_modificacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Tarea` varchar(150) DEFAULT NULL,
  `usuario` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`)
)


/* --------------Creacion tabla parcheo PATCHING--------------- */

CREATE TABLE `patching` (
  `Building` varchar(45) NOT NULL,
  `Floor` int(11) NOT NULL,
  `Closet` varchar(45) DEFAULT NULL,
  `Panel` varchar(45) DEFAULT NULL,
  `Panel_Port` varchar(45) DEFAULT NULL,
  `Stack` varchar(45) DEFAULT NULL,
  `Switch` varchar(45) DEFAULT NULL,
  `Switch_Port` varchar(45) DEFAULT NULL,
  `Interfaz` varchar(45) DEFAULT NULL,
  `Link` varchar(45) DEFAULT NULL,
  `Speed` varchar(45) DEFAULT NULL,
  `Duplex` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Vlan` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `IP_Switch` varchar(45) DEFAULT NULL,
  `WORK_ORDER` varchar(150) DEFAULT NULL,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`,`Building`)
) 


  /*----------------------------Creacion tabla logs parcheo Patching------------------------*/

CREATE TABLE `log_patching` (
  `Accion` VARCHAR(150) NULL,
  `Building` varchar(45) NULL,
  `Floor` varchar(45) NULL,
  `Closet` varchar(45) DEFAULT NULL,
  `Panel` varchar(45) DEFAULT NULL,
  `Panel_Port` varchar(45) DEFAULT NULL,
  `Stack` varchar(45) DEFAULT NULL,
  `Switch` varchar(45) DEFAULT NULL,
  `Switch_Port` varchar(45) DEFAULT NULL,
  `Interfaz` varchar(45) DEFAULT NULL,
  `Link` varchar(45) DEFAULT NULL,
  `Speed` varchar(45) DEFAULT NULL,
  `Duplex` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Vlan` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `IP_Switch` varchar(45) DEFAULT NULL,
  `User` VARCHAR(150) NULL,
  `WORK_ORDER` varchar(150) DEFAULT NULL,
  `Date` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
   ON UPDATE CURRENT_TIMESTAMP,
    `ID` INT NOT NULL AUTO_INCREMENT,
    PRIMARY KEY (`ID`)
) 




/* --------------Creacion tabla usuarios--------------- */

 CREATE TABLE `npms`.`Usuarios` (
  `Usuario` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `Nivel` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Usuario`),
  UNIQUE INDEX `Usuario_UNIQUE` (`Usuario` ASC) VISIBLE);
  INSERT INTO `npms`.`usuarios` (`Usuario`, `Password`, `Nivel`) VALUES ('root', 'DC76E9F0C0006E8F919E0C515C66DBBA3982F785', 'administrador');



/* --------------Creacion tabla vlan_ipv4--------------- */

CREATE TABLE `npms`.`vlan_ipv4` (
  `Vlan` INT NOT NULL,
  `Nombre` VARCHAR(150) NULL,
  `Ubicacion` VARCHAR(150) NULL,
  `Vsys/balanceador/otro` VARCHAR(150) NULL,
  `Descripcion` VARCHAR(150) NULL,
  `Direccion_red` VARCHAR(65) NOT NULL,
  `Rango_ip_inicio` VARCHAR(65) NULL,
  `Rango_ip_fin` VARCHAR(65) NULL,
  `Mascara` VARCHAR(65) NULL,
  `Gateway` VARCHAR(100) NULL,
  `Observaciones` VARCHAR(200) NULL,
  `Dispositivo` VARCHAR(150) NULL,
  `Firewall` VARCHAR(150) NULL,
  `Entorno` VARCHAR(150) NULL,
  `Normativa` VARCHAR(150) NULL,
  `Estado` VARCHAR(150) NULL,
  `Tipo_de_red` VARCHAR(150) NULL,
  `Equipos` VARCHAR(150) NULL,
  `Clasificacion` VARCHAR(150) NULL,
  `Tarea` VARCHAR(150) NULL,
  `Usuario` VARCHAR(150) NULL,
  `Fecha` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
  ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Vlan`, `Direccion_red`),
  UNIQUE INDEX `Vlan_UNIQUE` (`Vlan` ASC) VISIBLE,
  UNIQUE INDEX `Direccion_red_UNIQUE` (`Direccion_red` ASC) VISIBLE);

/* --------------Creacion tabla logs vlan IPv4--------------- */

CREATE TABLE `npms`.`log_vlan_ipv4` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Accion` VARCHAR(150) NULL,
  `Vlan` INT NOT NULL,
  `Nombre` VARCHAR(150) NULL,
  `Ubicacion` VARCHAR(150) NULL,
  `Vsys/balanceador/otro` VARCHAR(150) NULL,
  `Descripcion` VARCHAR(150) NULL,
  `Direccion_red` VARCHAR(65) NOT NULL,
  `Rango_ip_inicio` VARCHAR(65) NULL,
  `Rango_ip_fin` VARCHAR(65) NULL,
  `Mascara` VARCHAR(65) NULL,
  `Gateway` VARCHAR(65) NULL,
  `Observaciones` VARCHAR(200) NULL,
  `Dispositivo` VARCHAR(150) NULL,
  `Firewall` VARCHAR(150) NULL,
  `Entorno` VARCHAR(150) NULL,
  `Normativa` VARCHAR(150) NULL,
  `Estado` VARCHAR(150) NULL,
  `Tipo_de_red` VARCHAR(150) NULL,
  `Equipos` VARCHAR(150) NULL,
  `Clasificacion` VARCHAR(150) NULL,
  `Tarea` VARCHAR(150) NULL,
  `Usuario` VARCHAR(150) NULL,
  `Fecha` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
  ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE INDEX `Vlan_UNIQUE` (`ID` ASC) VISIBLE);

/* --------------Creacion vlan_ipv6 --------------- */


  CREATE TABLE `npms`.`vlan_ipv6` (
  `Vlan` INT NOT NULL,
  `Nombre` VARCHAR(150) NULL,
  `Ubicacion` VARCHAR(150) NULL,
  `Vsys/balanceador/otro` VARCHAR(150) NULL,
  `Descripcion` VARCHAR(150) NULL,
  `Direccion_red` VARCHAR(65) NOT NULL,
  `Rango_ip_inicio` VARCHAR(65) NULL,
  `Rango_ip_fin` VARCHAR(65) NULL,
  `Mascara` VARCHAR(65) NULL,
  `Gateway` VARCHAR(65) NULL,
  `Observaciones` VARCHAR(200) NULL,
  `Dispositivo` VARCHAR(150) NULL,
  `Firewall` VARCHAR(150) NULL,
  `Entorno` VARCHAR(150) NULL,
  `Normativa` VARCHAR(150) NULL,
  `Estado` VARCHAR(150) NULL,
  `Tipo_de_red` VARCHAR(150) NULL,
  `Equipos` VARCHAR(150) NULL,
  `Clasificacion` VARCHAR(150) NULL,
  `Tarea` VARCHAR(150) NULL,
  `Usuario` VARCHAR(150) NULL,
  `Fecha` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
  ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Vlan`, `Direccion_red`),
  UNIQUE INDEX `Vlan_UNIQUE` (`Vlan` ASC) VISIBLE,
  UNIQUE INDEX `Direccion_red_UNIQUE` (`Direccion_red` ASC) VISIBLE);

  /* --------------Creacion tabla log vlan IPv6--------------- */

CREATE TABLE `npms`.`log_vlan_ipv6` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Accion` VARCHAR(150) NULL,
  `Vlan` INT NOT NULL,
  `Nombre` VARCHAR(150) NULL,
  `Ubicacion` VARCHAR(150) NULL,
  `Vsys/balanceador/otro` VARCHAR(150) NULL,
  `Descripcion` VARCHAR(150) NULL,
  `Direccion_red` VARCHAR(150) NOT NULL,
  `Rango_ip_inicio` VARCHAR(150) NULL,
  `Rango_ip_fin` VARCHAR(150) NULL,
  `Mascara` VARCHAR(150) NULL,
  `Gateway` VARCHAR(200) NULL,
  `Observaciones` VARCHAR(200) NULL,
  `Dispositivo` VARCHAR(150) NULL,
  `Firewall` VARCHAR(150) NULL,
  `Entorno` VARCHAR(150) NULL,
  `Normativa` VARCHAR(150) NULL,
  `Estado` VARCHAR(150) NULL,
  `Tipo_de_red` VARCHAR(150) NULL,
  `Equipos` VARCHAR(150) NULL,
  `Clasificacion` VARCHAR(150) NULL,
  `Tarea` VARCHAR(150) NULL,
  `Usuario` VARCHAR(150) NULL,
  `Fecha` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
  ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE INDEX `Vlan_UNIQUE` (`ID` ASC) VISIBLE);


  /* --------------Creacion tabla inventarios--------------- */

CREATE TABLE `npms`.`inventory` (
  `HOSTNAME` VARCHAR(60) NULL,
  `DNS` VARCHAR(60) NULL,
  `COMMENTS` VARCHAR(60) NULL,
  `IP` VARCHAR(60) NULL,
  `SN` VARCHAR(60) NOT NULL,
  `NAME` VARCHAR(60) NULL,
  `MANUFACTURER` VARCHAR(60) NULL,
  `LOCATION` VARCHAR(60) NULL,
  `ENVIRONMENT` VARCHAR(60) NULL,
  `DOMAIN` VARCHAR(60) NULL,
  `CONTACT_PROPERTY` VARCHAR(60) NULL,
  `ADITIONAL_INFO` VARCHAR(60) NULL,
  `PORTS` VARCHAR(60) NULL,
  `OTHER_1` VARCHAR(60) NULL,
  `OTHER_2` VARCHAR(60) NULL,
  `DATE` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `WORK_ORDER` varchar(150) DEFAULT NULL,
  `USER` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`SN`),
  UNIQUE INDEX `SN_UNIQUE` (`SN` ASC) VISIBLE);

/*----------------------------Creacion tabla logs Inventory------------------------*/

CREATE TABLE `npms`.`log_inventory` (
  `ID` INT(50) NOT NULL AUTO_INCREMENT,
  `ACTION` VARCHAR(60) NULL,
  `HOSTNAME` VARCHAR(60) NULL,
  `DNS` VARCHAR(60) NULL,
  `COMMENTS` VARCHAR(60) NULL,
  `IP` VARCHAR(60) NULL,
  `SN` VARCHAR(60) NOT NULL,
  `NAME` VARCHAR(60) NULL,
  `MANUFACTURER` VARCHAR(60) NULL,
  `LOCATION` VARCHAR(60) NULL,
  `ENVIRONMENT` VARCHAR(60) NULL,
  `DOMAIN` VARCHAR(60) NULL,
  `CONTACT_PROPERTY` VARCHAR(60) NULL,
  `ADITIONAL_INFO` VARCHAR(60) NULL,
  `PORTS` VARCHAR(60) NULL,
  `OTHER_1` VARCHAR(60) NULL,
  `OTHER_2` VARCHAR(60) NULL,
  `DATE` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `WORK_ORDER` varchar(150) DEFAULT NULL,
  `USER` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE);



/* --------------Creacion tabla logs IPv4--------------- */

CREATE TABLE `log_ip_ipv4` (
  `ID` INT(20) NOT NULL AUTO_INCREMENT,
  `IP` varchar(30) NOT NULL,
  `Accion` varchar(45) DEFAULT NULL,
  `Vlan` int(11) NOT NULL,
  `Ubicacion` varchar(150) DEFAULT NULL,
  `Mac` varchar(40) DEFAULT NULL,
  `DNS` varchar(150) DEFAULT NULL,
  `Descripcion` varchar(150) DEFAULT NULL,
  `Hostname_revisado` varchar(150) DEFAULT NULL,
  `Hostname` varchar(150) DEFAULT NULL,
  `Fecha_modificacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Tarea` varchar(150) DEFAULT NULL,
  `usuario` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`)
)


DELIMITER $$
CREATE PROCEDURE `Create_vlan_ipv6`(in id_vlan varchar(30),
in id_nombre_vlan varchar(100),in id_Ubicacion varchar(100),in id_Vsys varchar(100),
in id_Descripcion varchar(150),in id_DireccionRed varchar(150),in id_RangoInicio varchar(150),
in id_RangoFin varchar(150),in id_Mascara varchar(150),
in id_Gateway1 varchar(150),
in formateo_vlan varchar(150),
in id_Observaciones varchar(100),in id_Dispositivo varchar(100),in id_Firewall varchar(100),
in id_Entorno varchar(100),in id_Normativa varchar(100),in id_Estado varchar(100),
in id_TipoRed varchar(100),in id_Equipos varchar(100),in id_Clasificacion varchar(100),
in id_Tarea varchar(100),in id_Usuario varchar(100))
BEGIN
declare gateway_aton varchar(150);
set gateway_aton = HEX(INET6_ATON(id_Gateway1));

/*************insertar datos en tabla VLAN  *************/
SET @s = CONCAT("INSERT INTO `npms`.`vlan_ipv6` (`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" ,
"VALUES('" , id_vlan , "','" , id_nombre_vlan , "','" , id_Ubicacion , "','" , id_Vsys , "',
'" , id_Descripcion , "','" , id_DireccionRed , "','" , id_RangoInicio , "','" , id_RangoFin , "',
'" , id_Mascara , "',' " , id_Gateway1 , "','" , id_Observaciones , "','" , id_Dispositivo , "',
'" , id_Firewall , "','" , id_Entorno , "','" , id_Normativa , "',' " , id_Estado , "',
'" , id_TipoRed , "', '" , id_Equipos , "','" , id_Clasificacion , "', '" , id_Tarea , "', 
'" , id_Usuario , "');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;  
/********* SENTENCIA RELLENAR LOGS****************/
SET @log = CONCAT("INSERT INTO `npms`.`log_vlan_ipv6` (`Accion`,`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" ,
"VALUES('Create','" , id_vlan , "','" , id_nombre_vlan , "','" , id_Ubicacion , "','" , id_Vsys , "',
'" , id_Descripcion , "','" , id_DireccionRed , "','" , id_RangoInicio , "','" , id_RangoFin , "',
'" , id_Mascara , "',' " , id_Gateway1 , "','" , id_Observaciones , "','" , id_Dispositivo , "',
'" , id_Firewall , "','" , id_Entorno , "','" , id_Normativa , "',' " , id_Estado , "',
'" , id_TipoRed , "', '" , id_Equipos , "','" , id_Clasificacion , "', '" , id_Tarea , "', 
'" , id_Usuario , "');");
    PREPARE stmt FROM @log;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
   
    /************** CREAR TABLA IP ******************/
set @Ctable = CONCAT("
CREATE TABLE `",formateo_vlan,"` (
`ID` int(11) NOT NULL AUTO_INCREMENT,
`Vlan` int(11) NOT NULL,
`IP` varchar(150) NOT NULL,
`Ubicacion` varchar(150) DEFAULT NULL,
`Mac` varchar(150) DEFAULT NULL,
`DNS` varchar(150) DEFAULT NULL,
`Descripcion` varchar(150) DEFAULT NULL,
`Hostname_revisado` varchar(150) DEFAULT NULL,
`Hostname` varchar(150) DEFAULT NULL,
`Fecha_modificacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
`Tarea` varchar(150) DEFAULT NULL,
`usuario` varchar(150) DEFAULT NULL,
PRIMARY KEY (`ID`,`IP`),
UNIQUE KEY `IP_UNIQUE` (`IP`),
UNIQUE KEY `ID_UNIQUE` (`ID`)
)");
    PREPARE stmt FROM @Ctable;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
/* //////////////// Rellenar tabla ip ////////////////// */
   set @ingate1 = CONCAT("INSERT INTO `npms`.`",formateo_vlan,"` 
   (`Vlan`, `IP`, `Ubicacion`, `Mac`, `DNS`, `Descripcion`, `Hostname_revisado`, `Hostname`, `Tarea`, `usuario`) 
   VALUES ('" , id_vlan , "', '" , id_Gateway1 , "', 'Gateway', 
   'Gateway', 'Gateway', 'Gateway', 'Gateway', 'Gateway', '" , id_Tarea , "', '" , id_Usuario , "');");
    PREPARE stmt FROM @ingate1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
    

END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `update_vlan_log_ipv4`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) , IN VarVlan varchar(20) , IN VarTarea varchar(50))
BEGIN

insert into log_vlan_ipv4 (`Vlan` ,`Nombre`,`Ubicacion`,`Vsys/balanceador/otro`,`Descripcion`,`Direccion_red`,
`Rango_ip_inicio`,`Rango_ip_fin`,`Mascara`,`Gateway`,`Observaciones`,`Dispositivo`,
`Firewall`,`Entorno`,`Normativa`,`Estado`,`Tipo_de_red`,`Equipos` ,`Clasificacion`,`Tarea`,`Usuario`)
select `Vlan`, `Nombre`, `Ubicacion`,`Vsys/balanceador/otro`,`Descripcion`,`Direccion_red`,
`Rango_ip_inicio`,`Rango_ip_fin`,`Mascara`,`Gateway`,`Observaciones`,
`Dispositivo`,`Firewall`,`Entorno`,`Normativa`,`Estado`,`Tipo_de_red`,`Equipos`,
`Clasificacion`,`Tarea`,`Usuario`
from vlan_ipv4
where Vlan = VarVlan;
SET @max_id = (SELECT MAX(ID) FROM log_vlan_ipv4);
UPDATE `npms`.`log_vlan_ipv4` SET `Accion` = VarAccion, `Tarea` = VarTarea, `Usuario` = VarUsuario WHERE `ID` = @max_id; 
DELETE FROM `npms`.vlan_ipv4 WHERE (`Vlan` = VarVlan);
 SET @s = CONCAT("DROP TABLE IF EXISTS `",VarVlan,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `insert_ip_ipv4`(in id_accion varchar(30),
in id_vlan varchar(30),in id_ip varchar(30),in id_Ubicacion varchar(30),in id_mac varchar(30),
in id_dns varchar(30),in id_Descripcion varchar(30),in id_hostnameR varchar(30),
in id_hostname varchar(30),in id_Tarea varchar(30),in id_usuario varchar(30))
BEGIN
declare ip_aton varchar(50);
set ip_aton = inet_aton(id_ip);
SET @s = CONCAT("UPDATE `npms`.`",id_vlan,"` SET 
`Ubicacion` = '",id_Ubicacion,"', 
`Mac` = '",id_mac,"', 
`DNS` = '",id_dns,"', 
`Descripcion` = '",id_Descripcion,"', 
`Hostname_revisado` = '",id_hostnameR,"', 
`Hostname` = '",id_hostname,"', 
`Tarea` = '",id_Tarea,"', 
`usuario` = '",id_usuario,"' 
WHERE (`IP` = '",ip_aton,"');

");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b = CONCAT("INSERT INTO `npms`.`log_ip_ipv4` 
(`IP`, `Accion`, `Vlan`, `Ubicacion`, `Mac`, `DNS`, `Descripcion`, `Hostname_revisado`, `Hostname`, `Tarea`, `usuario`) 
VALUES ('",ip_aton,"', '",id_accion,"', '",id_vlan,"','",id_Ubicacion,"',
'",id_mac,"', '",id_dns,"', '",id_Descripcion,"', '",id_hostnameR,"', '",id_hostname,"', 
'",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;



DELIMITER $$
CREATE PROCEDURE `rellenar_tabla_ip_ipv4`(in initial_range varchar (40),
in broadcast varchar (40), in id_vlan int(30))
BEGIN
declare in_range varchar(50);
declare fin_range varchar(50);
set in_range = inet_aton(initial_range);
set fin_range = inet_aton(broadcast);

SET @s = CONCAT("INSERT INTO `npms`.`",id_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
bucle: LOOP
set in_range = in_range+1;
if in_range = fin_range then
leave bucle;
end if;
SET @s1 = CONCAT("INSERT INTO `npms`.`",id_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END LOOP bucle;
END$$
DELIMITER ;


DELIMITER $$
CREATE  PROCEDURE `select_ipv4_ip`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(",campo,"),Vlan,Ubicacion,Mac,DNS,
Descripcion,Hostname_revisado,Hostname,Fecha_modificacion,Tarea,usuario
FROM npms.`",tabla,"` ;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `select_ipv4_ip_desc`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Accion,INET_NTOA(",campo,"),Vlan,Ubicacion,Mac,DNS,
Descripcion,Hostname_revisado,Hostname,Fecha_modificacion,Tarea,usuario
FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE `update_ip_log_ipv4`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN VarIP varchar(30), IN VarVlan varchar(30), IN VarTarea varchar(50))
BEGIN
declare ip_aton varchar(50);
set ip_aton = inet_aton(VarIP);
  SET @s = CONCAT("insert into `log_ip_ipv4`
(`IP` ,`Vlan`,`Ubicacion`,`Mac`,`DNS`,`Descripcion`,`Hostname_revisado`,`Hostname`,`tarea`,`usuario`)
select `IP`, `Vlan`, `Ubicacion`,`Mac`,`DNS`,
`Descripcion`,`Hostname_revisado`,`Hostname`,
`tarea`,`usuario`
from `",VarVlan,"` where IP ='", ip_aton,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("UPDATE `npms`.`",VarVlan,"` SET 
 `Ubicacion` = '', 
 `Mac` = '', 
 `DNS` = '', 
 `Descripcion` = '', 
 `Hostname_revisado` = '', 
 `Hostname` = '', 
 `Tarea` = '', 
 `usuario` = '' WHERE  (`IP` = '",ip_aton,"');
");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_ip_ipv4);
UPDATE `npms`.`log_ip_ipv4` SET `Accion` = VarAccion, `Tarea` = VarTarea, `Usuario` = VarUsuario WHERE `ID` = @max_id;    
END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE `Create_vlan_ipv4`(in id_vlan varchar(30),
in id_nombre_vlan varchar(100),in id_Ubicacion varchar(100),in id_Vsys varchar(100),
in id_Descripcion varchar(100),in id_DireccionRed varchar(100),in id_RangoInicio varchar(100),
in id_RangoFin varchar(100),in id_Mascara varchar(100),
in id_Gateway1 varchar(100),
in Broadcast varchar(100),
in id_Observaciones varchar(100),in id_Dispositivo varchar(100),in id_Firewall varchar(100),
in id_Entorno varchar(100),in id_Normativa varchar(100),in id_Estado varchar(100),
in id_TipoRed varchar(100),in id_Equipos varchar(100),in id_Clasificacion varchar(100),
in id_Tarea varchar(100),in id_Usuario varchar(100))
BEGIN
declare gateway_aton varchar(50);
set gateway_aton = inet_aton(id_Gateway1);
/*************insertar datos en tabla VLAN  *************/
SET @s = CONCAT("INSERT INTO `npms`.`vlan_ipv4` (`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" ,
"VALUES('" , id_vlan , "','" , id_nombre_vlan , "','" , id_Ubicacion , "','" , id_Vsys , "',
'" , id_Descripcion , "','" , id_DireccionRed , "','" , id_RangoInicio , "','" , id_RangoFin , "',
'" , id_Mascara , "',' " , id_Gateway1 , "','" , id_Observaciones , "','" , id_Dispositivo , "',
'" , id_Firewall , "','" , id_Entorno , "','" , id_Normativa , "',' " , id_Estado , "',
'" , id_TipoRed , "', '" , id_Equipos , "','" , id_Clasificacion , "', '" , id_Tarea , "', 
'" , id_Usuario , "');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;  
/********* SENTENCIA RELLENAR LOGS****************/
SET @log = CONCAT("INSERT INTO `npms`.`log_vlan_ipv4` (`Accion`,`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" ,
"VALUES('Create','" , id_vlan , "','" , id_nombre_vlan , "','" , id_Ubicacion , "','" , id_Vsys , "',
'" , id_Descripcion , "','" , id_DireccionRed , "','" , id_RangoInicio , "','" , id_RangoFin , "',
'" , id_Mascara , "',' " , id_Gateway1 , "','" , id_Observaciones , "','" , id_Dispositivo , "',
'" , id_Firewall , "','" , id_Entorno , "','" , id_Normativa , "',' " , id_Estado , "',
'" , id_TipoRed , "', '" , id_Equipos , "','" , id_Clasificacion , "', '" , id_Tarea , "', 
'" , id_Usuario , "');");
    PREPARE stmt FROM @log;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
   
    /************** CREAR TABLA IP ******************/
set @Ctable = CONCAT("
CREATE TABLE `",id_vlan,"` (
`ID` int(11) NOT NULL AUTO_INCREMENT,
`Vlan` int(11) NOT NULL,
`IP` varchar(30) NOT NULL,
`Ubicacion` varchar(150) DEFAULT NULL,
`Mac` varchar(30) DEFAULT NULL,
`DNS` varchar(150) DEFAULT NULL,
`Descripcion` varchar(150) DEFAULT NULL,
`Hostname_revisado` varchar(150) DEFAULT NULL,
`Hostname` varchar(150) DEFAULT NULL,
`Fecha_modificacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
`Tarea` varchar(150) DEFAULT NULL,
`usuario` varchar(150) DEFAULT NULL,
PRIMARY KEY (`ID`,`IP`),
UNIQUE KEY `IP_UNIQUE` (`IP`),
UNIQUE KEY `ID_UNIQUE` (`ID`)
)");
    PREPARE stmt FROM @Ctable;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
/* //////////////// Rellenar tabla ip ////////////////// */
call rellenar_tabla_ip_ipv4(id_RangoInicio,Broadcast,id_vlan);

   set @ingate1 = CONCAT("UPDATE `npms`.`",id_vlan,"` SET `Ubicacion` = 'gateway1', 
   `Mac` = 'Gateway1', 
   `DNS` = 'Gateway1', 
   `Descripcion` = 'Gateway1', 
   `Hostname_revisado` = 'Gateway1', 
   `Hostname` = 'Gateway1' 
   WHERE (`IP` = '",gateway_aton,"');");
    PREPARE stmt FROM @ingate1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
    

END$$
DELIMITER ;



/*********************Procedure que borra building entero (edificio delete)(parcheo)***************************/
DELIMITER $$
CREATE PROCEDURE `delete_all_building`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Accion`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`)  
VALUES ('Delete', '",Building,"', 'ALL', 'ALL',
 'ALL', 'ALL', 'ALL', 'ALL', 
 'ALL', 'ALL', 'ALL', 'ALL', 
 'ALL', 'ALL', 'ALL', 'ALL', 
 'ALL', '",VarUsuario,"', '",VarTarea,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` WHERE Building = '",Building,"';");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;
/*********************Procedure que borra Closet (Armario) entero en patching (floor delete)(parcheo)***************************/


DELIMITER $$
CREATE PROCEDURE `delete_all_closet`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50),IN Floor varchar(50),IN Closet varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Accion`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`)  
VALUES ('",VarAccion,"', '",Building,"', '",Floor,"', '",Closet,"',
 'Closet_All', 'Closet_All', 'Closet_All', 'Closet_All', 
 'Closet_All', 'Closet_All', 'Closet_All', 'Closet_All', 
 'Closet_All', 'Closet_All', 'Closet_All', 'Closet_All', 
 'Closet_All', '",VarUsuario,"', '",VarTarea,"');
");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` WHERE (`Building` = '",Building,"' and `Floor` = '",Floor,"' and `Closet` = '",Closet,"' );");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;
/*********************Procedure que borra Floor (planta) entero en patching (floor delete)(parcheo)***************************/
DELIMITER $$
CREATE PROCEDURE `delete_all_floor`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50),IN Floor varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Accion`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`)  
VALUES ('",VarAccion,"', '",Building,"', '",Floor,"', 'Floor_ALL',
 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 
 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 
 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 
 'Floor_ALL', '",VarUsuario,"', '",VarTarea,"');
");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` WHERE (`Building` = '",Building,"' and `Floor` = '",Floor,"' );");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;





/*********************Procedure que borra field (fila) patching (parcheo)***************************/

DELIMITER $$
CREATE PROCEDURE `delete_field_patching`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN VarTarea varchar(50),
IN Building varchar(50),IN Floor varchar(50),IN Closet varchar(50)
,IN Panel varchar(50),IN Panel_port varchar(50),IN Stack varchar(50),IN IP_switch varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`)  
select `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`
from `patching` where (`Building` = '",Building,"' and `Floor` = '",Floor,"' and `Closet` = '",Closet,"'
and `Panel` = '",Panel,"' and `Panel_Port` = '",Panel_port,"' and `Stack` = '",Stack,"' and `IP_Switch` = '",IP_switch,"' );");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_patching);
UPDATE `npms`.`log_patching` SET `Accion` = VarAccion, `WORK_ORDER` = VarTarea, `User` = VarUsuario WHERE `ID` = @max_id; 
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` where (`Building` = '",Building,"' and `Floor` = '",Floor,"' and `Closet` = '",Closet,"'
and `Panel` = '",Panel,"' and `Panel_Port` = '",Panel_port,"' and `Stack` = '",Stack,"' and `IP_Switch` = '",IP_switch,"' );");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;



/*********************Procedure insert Patching Parcheo***************************/

DELIMITER $$
CREATE PROCEDURE `insert_patching`(in Building varchar(30),
in Floor varchar(30),in Closet varchar(30),in Panel varchar(30),in Panel_Port varchar(30),
in Stack varchar(30),in Switch varchar(30),in Switch_Port varchar(30),
in Interfaz varchar(30),in Link varchar(30),in Speed varchar(30)
,in Duplex varchar(30),in Type_ varchar(30),in Vlan varchar(30)
,in Description_ varchar(30),in IP_Switch varchar(30)
,in User_ varchar(30),in workOrder varchar(30),in Accion_ varchar(30))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`patching` 
(`Building`, `Floor`, `Closet`, `Panel`, 
`Panel_Port`, `Stack`, `Switch`, `Switch_Port`, 
`Interfaz`, `Link`, `Speed`, `Duplex`, 
`Type`, `Vlan`,`Description`, 
`IP_Switch`,`WORK_ORDER`) 
 VALUES ('",Building,"', '",Floor,"', '",Closet,"', '",Panel,"', 
 '",Panel_Port,"', '",Stack,"', '",Switch,"', '",Switch_Port,"', 
 '",Interfaz,"', '",Link,"', '",Speed,"', '",Duplex,"', 
 '",Type_,"', '",Vlan,"', '",Description_,"', 
 '",IP_Switch,"', '",workOrder,"');

");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Accion`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`) 
 VALUES ('",Accion_,"', '",Building,"', '",Floor,"', '",Closet,"',
 '",Panel,"', '",Panel_Port,"', '",Stack,"', '",Switch,"', 
 '",Switch_Port,"', '",Interfaz,"', '",Link,"', '",Speed,"', 
 '",Duplex,"', '",Type_,"', '",Vlan,"', '",Description_,"', 
 '",IP_Switch,"', '",User_,"','",workOrder,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;


/*********************Procedure que obtiene los campos de PATCHING (parcheo)***************************/

DELIMITER $$
CREATE PROCEDURE `select_patching`(in building varchar(30),in floor varchar(30),
in closet varchar(30),in panel varchar(30),in port_panel varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.patching where Building = '",building,"' and floor = '",floor,"' and closet = '",closet,"' 
and panel = '",panel,"' and Panel_port = '",port_panel,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;


/*********************Procedure update inventory***************************/


DELIMITER $$
CREATE PROCEDURE `update_inventory_log`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN SN varchar(50),IN VarTarea varchar(50))
BEGIN
  SET @s = CONCAT("insert into `log_inventory`
(`HOSTNAME`, `DNS`, `COMMENTS`, `IP`, `SN`, `NAME`, 
`MANUFACTURER`, `LOCATION`, `ENVIRONMENT`, `DOMAIN`, `CONTACT_PROPERTY`, 
`ADITIONAL_INFO`, `PORTS`, `OTHER_1`, `OTHER_2`, `WORK_ORDER`, `USER`) 
select `HOSTNAME`, `DNS`,`COMMENTS`,`IP`,`SN`,`NAME`,
`MANUFACTURER`,`LOCATION`,`ENVIRONMENT`,`DOMAIN`,
`CONTACT_PROPERTY`,`ADITIONAL_INFO`,`PORTS`,`OTHER_1`,`OTHER_2`
,`WORK_ORDER`,`USER`
from `inventory` where SN ='", SN,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`inventory` WHERE SN = '",SN,"';");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_inventory);
UPDATE `npms`.`log_inventory` SET `ACTION` = VarAccion, `WORK_ORDER` = VarTarea, `USER` = VarUsuario WHERE `ID` = @max_id;  
END$$
DELIMITER ;




/*********************Procedure insert inventory***************************/

DELIMITER $$
CREATE PROCEDURE `insert_inventory`(in accion varchar(80),
in hostname varchar(80),in dns varchar(80),in comments varchar(80),in ip varchar(80),
in sn varchar(80),in nombre varchar(80),in manufacturer varchar(80),
in location varchar(80),in environment varchar(80),in domain varchar(80)
,in contact varchar(80),in aditionalinfo varchar(80),in ports varchar(80)
,in other1 varchar(80),in other2 varchar(80),in worder varchar(80),in usuario varchar(80))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`inventory` 
(`HOSTNAME`, `DNS`, `COMMENTS`, `IP`, `SN`, `NAME`, 
`MANUFACTURER`, `LOCATION`, `ENVIRONMENT`, `DOMAIN`, `CONTACT_PROPERTY`, 
`ADITIONAL_INFO`, `PORTS`, `OTHER_1`, `OTHER_2`, `WORK_ORDER`, `USER`) 
VALUES 
('",hostname,"', '",dns,"', '",comments,"', '",ip,"', '",sn,"', '",nombre,"', 
'",manufacturer,"', '",location,"', '",environment,"', '",domain,"', '",contact,"', 
'",aditionalinfo,"', '",ports,"', '",other1,"', '",other2,"', '",worder,"', '",usuario,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b =  CONCAT("INSERT INTO `npms`.`log_inventory` 
(`ACTION`, `HOSTNAME`, `DNS`, `COMMENTS`, `IP`, `SN`, `NAME`, 
`MANUFACTURER`, `LOCATION`, `ENVIRONMENT`, `DOMAIN`, `CONTACT_PROPERTY`, 
`ADITIONAL_INFO`, `PORTS`, `OTHER_1`, `OTHER_2`, `WORK_ORDER`, `USER`) 
VALUES 
('",accion,"', '",hostname,"', '",dns,"', '",comments,"', '",ip,"', '",sn,"', '",nombre,"', 
'",manufacturer,"', '",location,"', '",environment,"', '",domain,"', '",contact,"', 
'",aditionalinfo,"', '",ports,"', '",other1,"', '",other2,"', '",worder,"', '",usuario,"');");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;





/*********************Procedure que busca la vlan correspondiente a una IP***************************/
DELIMITER $$
CREATE PROCEDURE `search_vlan_for_IP`(in tabla varchar(30),
in Dato varchar(30),in CampoMenor varchar(30),in CampoMayor varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where (INET_ATON('",Dato,"') 
BETWEEN INET_ATON(",CampoMenor,")and INET_ATON(",CampoMayor,"));");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;


/*********************Procedure que muestra el FAST FIREWALL***************************/
DELIMITER $$
CREATE PROCEDURE `search_vlan_for_Fast_Firewall`(in tabla varchar(30),
in origen varchar(30),in destino varchar(30))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",origen,"') 
BETWEEN INET_ATON(Rango_ip_inicio)and INET_ATON(Rango_ip_fin)))
union(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",destino,"') 
BETWEEN INET_ATON(Rango_ip_inicio)and INET_ATON(Rango_ip_fin))); ");

    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
/*********************Procedure que comprueba si una tabla existe***************************/
DELIMITER $$
CREATE  PROCEDURE `table_exists`(
in tabla varchar (40))
BEGIN
SET @s = CONCAT("SHOW TABLES LIKE '",tabla,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
/*********************Procedure que borra una fila por el valor de un campo(DELETE)***************************/
DELIMITER $$
CREATE PROCEDURE `simply_delete_where`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(100))
BEGIN
SET @s = CONCAT("Delete FROM npms.`",tabla,"` where ",campo," = '", datocampo,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

/*********************Procedure que crea usuarios***************************/

DELIMITER $$
CREATE  PROCEDURE `create_user`(in usuario varchar (40),in pass varchar (40),in rol varchar(100))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`usuarios` (`Usuario`, `Password`, `Nivel`) 
VALUES ('",usuario,"', '",pass,"', '",rol,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

/*********************Procedure que realiza un UPDATE de un campo, por where otro campo***************************/
DELIMITER $$
CREATE PROCEDURE `symply_where_update`(in tabla varchar (40),in campo1 varchar (40),in campo2 varchar(100),
in datocampo1 varchar (40), in datocampo2 varchar(100))
BEGIN
SET @s = CONCAT("UPDATE `npms`.`",tabla,"` SET ",campo1," = '", datocampo1,"' WHERE (`", campo2,"` = '",datocampo2,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
/*********************Procedure que busca una fila por el valor exacto de dos campos (LOGGING)***************************/

DELIMITER $$
CREATE PROCEDURE `simplyselectwhere2fields`(in tabla varchar (40),in campo1 varchar (40),
in campo2 varchar (40),in datocampo1 varchar(100),in datocampo2 varchar(100))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` WHERE ",campo1," = '", datocampo1,"' and ",campo2," = '", datocampo2,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
/*********************Procedure que hace SELETC* SOBRE DOS CAMPOS  (Ver datos de usuario)***************************/


DELIMITER $$
CREATE  PROCEDURE `simplyselect_view2fields`(
in tabla varchar (40),
in campo1 varchar (40),
in campo2 varchar (40))
BEGIN
SET @s = CONCAT("SELECT  ",campo1,",",campo2," FROM npms.`",tabla,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

/*********************Procedure que busca una fila por el valor de un campo (=)***************************/
DELIMITER $$
CREATE PROCEDURE `simplyselect`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where ",campo," = '", datocampo,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
/*********************Procedure que Hace un Select all***************************/

DELIMITER $$
CREATE PROCEDURE `simplyselectall`(in tabla varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

/*********************Procedure que busca una fila por el valor de una cadena (LIKE)***************************/
DELIMITER $$
CREATE PROCEDURE `simplyselectwherelike`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

/*********************Procedure que Hace un Select all con ORDER DESC (ideal para logs)***************************/
DELIMITER $$
CREATE PROCEDURE `simplyselectallorderdesc`(in tabla varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
/*********************Procedure obtiene todos los campos de una columan y borra duplicados (SELECT DISTINCT)***************************/
DELIMITER $$
CREATE PROCEDURE `select_distinct`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT DISTINCT ",campo," FROM npms.",tabla,";");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;