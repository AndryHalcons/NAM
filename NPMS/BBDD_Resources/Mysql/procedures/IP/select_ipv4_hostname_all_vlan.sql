DELIMITER $$
CREATE PROCEDURE `select_ipv4_hostname_all_vlan`(in name_domain varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Vlan,INET_NTOA(IP),DNS,Hostname
FROM npms.`domain_name` WHERE  (DNS LIKE '%",name_domain,"%' OR Hostname LIKE '%",name_domain,"%')");
PREPARE stmt FROM @s;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
