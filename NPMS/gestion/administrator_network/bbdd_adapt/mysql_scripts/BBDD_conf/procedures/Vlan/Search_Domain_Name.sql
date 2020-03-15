DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Search_Domain_Name`(in ip varchar(30))
BEGIN
declare contador int (50);
declare PosicionCampo int (50);
declare NumeroTablas int (50);
DECLARE existe boolean DEFAULT FALSE;
/* Preparamos el valor de el numero de tablas y creamos la tabla temporal */
Drop table if exists tabla_domain;
set @TablaTemporal = CONCAT ("CREATE TABLE `tabla_domain` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Vlan` int(11) NOT NULL,
  `IP` varchar(30) NOT NULL,
  `Location` varchar(150) DEFAULT NULL,
  `Mac` varchar(30) DEFAULT NULL,
  `DNS` varchar(150) DEFAULT NULL,
  `Description` varchar(150) DEFAULT NULL,
  `Revised_Hostname` varchar(150) DEFAULT NULL,
  `Hostname` varchar(150) DEFAULT NULL,
  `Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `Work_Order` varchar(150) DEFAULT NULL,
  `User` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`,`IP`),
  UNIQUE KEY `IP_UNIQUE` (`IP`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) 
");
PREPARE stmt FROM @TablaTemporal;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

/* declaramos las variables NumeroTablas y contador */
set NumeroTablas = 35;
set contador = '0';
/*************************** Iniciamos el bucle *********************/
bucle: LOOP
if contador = NumeroTablas then
leave bucle;
end if;
set contador = contador+1;
/*************** comprobamos que la tabla existe ***************/
SET @existe = CONCAT("IF EXISTS (SELECT * FROM npms.`",contador,"`)THEN
        SET existe = TRUE; 
        END IF;");
    PREPARE stmt FROM @existe;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   

/*
IF EXISTS (SELECT * FROM npms.contador)THEN
        SET existe = TRUE;
    END IF;
    */
IF existe = TRUE THEN
/*************** final comprobacion que la tabla existe ***************/
  SET @Inserccion = CONCAT("insert into `Tabla_domain`
(`IP` ,`Vlan`,`Location`,`Mac`,`DNS`,`Description`,`Revised_Hostname`,`Hostname`,`Work_Order`,`User`)
select `IP`, `Vlan`, `Location`,`Mac`,`DNS`,
`Description`,`Revised_Hostname`,`Hostname`,
`Work_Order`,`User`
from `",contador,"` where IP ='", ip,"'");
PREPARE stmt FROM @Inserccion;
EXECUTE stmt;
DEALLOCATE PREPARE stmt; 
END IF;
END LOOP bucle;
/*************** Final del bucle ***************/
SELECT * FROM npms.`Tabla_domain`;


END$$
DELIMITER ;