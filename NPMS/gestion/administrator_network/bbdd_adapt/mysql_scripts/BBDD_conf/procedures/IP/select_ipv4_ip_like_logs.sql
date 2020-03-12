DELIMITER $$
CREATE PROCEDURE `select_ipv4_ip_like_logs`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
declare campoaton varchar (50);
set campoaton = inet_aton(datocampo);
SET @s = CONCAT("SELECT ID,INET_NTOA(",campo,"),Action,Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", campoaton,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
