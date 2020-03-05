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

