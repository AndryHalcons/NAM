DELIMITER $$
CREATE PROCEDURE `search_vlan_for_ip`(in tabla varchar(30),
in origen varchar(30))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",origen,"') 
BETWEEN INET_ATON(Initial_Range)and INET_ATON(Final_Range)))");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
