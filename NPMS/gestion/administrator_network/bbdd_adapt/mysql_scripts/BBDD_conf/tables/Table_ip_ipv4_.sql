/* --------------Creacion tabla  IPv4--------------- */

CREATE TABLE `nombreTABLAIP` (
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
)