
  /*----------------------------Creacion tabla logs parcheo Patching------------------------*/

CREATE TABLE `log_patching` (
  `Action` VARCHAR(150) NULL,
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
