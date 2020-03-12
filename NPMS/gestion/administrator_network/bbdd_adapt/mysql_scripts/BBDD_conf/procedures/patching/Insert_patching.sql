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
(`Action`, `Building`, `Floor`, `Closet`,
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

