/*********************Procedure que hace SELETC* SOBRE DOS CAMPOS  (Ver datos de usuario)***************************/


DELIMITER $$
CREATE  PROCEDURE `simplyselect_view2fields`(
in tabla varchar (40),
in campo1 varchar (40),
in campo2 varchar (40))
BEGIN
SET @s = CONCAT("SELECT  ",campo1,",",campo2," FROM npms.`",tabla,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

