DELIMITER $$
CREATE PROCEDURE `select_ipv4_ip_like_other_fields_logs`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(IP),Action,Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
