/* --------------Creacion tabla  IPv6--------------- */

 CREATE TABLE `"intro ipv6_ & id_vlan"` (
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