DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_like_other_fields`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(IP),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
