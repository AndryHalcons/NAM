/* --------------Creacion tabla usuarios--------------- */

 CREATE TABLE `npms`.`Usuarios` (
  `User` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `Rol` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`User`),
  UNIQUE INDEX `User_UNIQUE` (`User` ASC) VISIBLE);
  INSERT INTO `npms`.`usuarios` (`User`, `Password`, `Nivel`) VALUES ('root', 'toor', 'administrador');
