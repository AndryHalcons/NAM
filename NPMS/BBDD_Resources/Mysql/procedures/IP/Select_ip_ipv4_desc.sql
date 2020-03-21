DELIMITER $$
CREATE PROCEDURE `select_ipv4_ip_desc`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Action,INET_NTOA(",campo,"),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
