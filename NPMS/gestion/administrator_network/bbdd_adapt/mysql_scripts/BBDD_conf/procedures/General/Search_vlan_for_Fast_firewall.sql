/*********************Procedure que muestra el FAST FIREWALL***************************/
DELIMITER $$
CREATE PROCEDURE `search_vlan_for_Fast_Firewall`(in tabla varchar(30),
in origen varchar(30),in destino varchar(30))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",origen,"') 
BETWEEN INET_ATON(Rango_ip_inicio)and INET_ATON(Rango_ip_fin)))
union(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",destino,"') 
BETWEEN INET_ATON(Rango_ip_inicio)and INET_ATON(Rango_ip_fin))); ");

    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
