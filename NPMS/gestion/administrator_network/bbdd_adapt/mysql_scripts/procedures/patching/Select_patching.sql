/*********************Procedure que obtiene los campos de PATCHING (parcheo)***************************/

DELIMITER $$
CREATE PROCEDURE `select_patching`(in building varchar(30),in floor varchar(30),
in closet varchar(30),in panel varchar(30),in port_panel varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.patching where Building = '",building,"' and floor = '",floor,"' and closet = '",closet,"' 
and panel = '",panel,"' and Panel_port = '",port_panel,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
