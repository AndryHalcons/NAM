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