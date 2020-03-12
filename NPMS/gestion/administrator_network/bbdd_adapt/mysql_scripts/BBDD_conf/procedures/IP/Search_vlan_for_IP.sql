
/*********************Procedure que busca la vlan correspondiente a una IP***************************/
DELIMITER $$
CREATE PROCEDURE `search_vlan_for_IP`(in tabla varchar(30),
in Dato varchar(30),in CampoMenor varchar(30),in CampoMayor varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where (INET_ATON('",Dato,"') 
BETWEEN INET_ATON(",CampoMenor,")and INET_ATON(",CampoMayor,"));");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;


