/* --------------Creacion tabla usuarios--------------- */

 CREATE TABLE `npms`.`Usuarios` (
  `Usuario` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `Nivel` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Usuario`),
  UNIQUE INDEX `Usuario_UNIQUE` (`Usuario` ASC) VISIBLE);
  INSERT INTO `npms`.`usuarios` (`Usuario`, `Password`, `Nivel`) VALUES ('root', 'toor', 'administrador');
