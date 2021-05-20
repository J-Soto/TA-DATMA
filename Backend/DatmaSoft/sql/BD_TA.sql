-- MySQL Script generated by MySQL Workbench
-- Tue May 11 21:08:10 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';


-- -----------------------------------------------------
-- Table `modulo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `modulo` ;

CREATE TABLE IF NOT EXISTS `modulo` (
  `idmodulo` INT NOT NULL AUTO_INCREMENT,
  `fechainicial` DATE NOT NULL,
  `fechafinal` DATE NOT NULL,
  PRIMARY KEY (`idmodulo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tipoactividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tipoactividad` ;

CREATE TABLE IF NOT EXISTS `tipoactividad` (
  `idtipoactividad` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(75) NOT NULL,
  `sincrono` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idtipoactividad`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `actividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `actividad` ;

CREATE TABLE IF NOT EXISTS `actividad` (
  `idactividad` INT NOT NULL AUTO_INCREMENT,
  `fidtipoactividad` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `fechaInicial` DATE NOT NULL,
  `horaincio` TIME NOT NULL,
  `horafin` TIME NOT NULL,
  PRIMARY KEY (`idactividad`),
  INDEX `fidtipoactividad_idx` (`fidtipoactividad` ASC) VISIBLE,
  CONSTRAINT `fk_fidtipoactividad_act`
    FOREIGN KEY (`fidtipoactividad`)
    REFERENCES `tipoactividad` (`idtipoactividad`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `persona`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `persona` ;

CREATE TABLE IF NOT EXISTS `persona` (
  `idpersona` INT NOT NULL AUTO_INCREMENT,
  `dni` VARCHAR(8) NOT NULL,
  `nombre` VARCHAR(75) NULL,
  `apellidopaterno` VARCHAR(25) NULL,
  `apellidomaterno` VARCHAR(25) NULL,
  `fechanacimiento` DATE NULL,
  `genero` CHAR(1) NULL,
  `edad` TINYINT(3) NULL,
  `telefono` VARCHAR(9) NULL,
  `celular` VARCHAR(9) NULL,
  `correo` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`idpersona`),
  UNIQUE INDEX `correo_UNIQUE` (`correo` ASC) VISIBLE,
  UNIQUE INDEX `telefono_UNIQUE` (`telefono` ASC) VISIBLE,
  UNIQUE INDEX `celular_UNIQUE` (`celular` ASC) VISIBLE,
  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `usuario` ;

CREATE TABLE IF NOT EXISTS `usuario` (
  `idusuario` INT NOT NULL AUTO_INCREMENT,
  `user` VARCHAR(75) NOT NULL,
  `password` VARCHAR(25) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  `tipo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idusuario`),
  UNIQUE INDEX `user_UNIQUE` (`user` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cuidador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cuidador` ;

CREATE TABLE IF NOT EXISTS `cuidador` (
  `fidpersona` INT NOT NULL,
  `fidusuario` INT NULL,
  `gestante` TINYINT(1) NULL,
  `bajosrecursos` TINYINT(1) NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidusuario_idx` (`fidusuario` ASC) VISIBLE,
  CONSTRAINT `fk_fidpersona_cuid`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidusuario_cuid`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tipoasistencia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tipoasistencia` ;

CREATE TABLE IF NOT EXISTS `tipoasistencia` (
  `idtipoasistencia` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idtipoasistencia`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `asistencia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `asistencia` ;

CREATE TABLE IF NOT EXISTS `asistencia` (
  `idasistencia` INT NOT NULL AUTO_INCREMENT,
  `fidusuario` INT NOT NULL,
  `fidactividad` INT NOT NULL,
  `fidtipoasistencia` INT NOT NULL,
  `descripcion` VARCHAR(250) NULL,
  INDEX `fidactividad_idx` (`fidactividad` ASC) VISIBLE,
  PRIMARY KEY (`idasistencia`),
  INDEX `fidtipoasistencia_idx` (`fidtipoasistencia` ASC) VISIBLE,
  INDEX `fidusuario_idx` (`fidusuario` ASC) VISIBLE,
  CONSTRAINT `fk_fidactividad_asist`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `actividad` (`idactividad`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidusuario_asist`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidtipoasistencia_asist`
    FOREIGN KEY (`fidtipoasistencia`)
    REFERENCES `tipoasistencia` (`idtipoasistencia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `distrito`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `distrito` ;

CREATE TABLE IF NOT EXISTS `distrito` (
  `iddistrito` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`iddistrito`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `persona_distrito`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `persona_distrito` ;

CREATE TABLE IF NOT EXISTS `persona_distrito` (
  `idpersona_distrito` INT NOT NULL AUTO_INCREMENT,
  `fiddistrito` INT NOT NULL,
  `fidpersona` INT NOT NULL,
  PRIMARY KEY (`idpersona_distrito`),
  INDEX `fidpersona_idx` (`fidpersona` ASC) VISIBLE,
  INDEX `fiddistrito_idx` (`fiddistrito` ASC) VISIBLE,
  CONSTRAINT `fk_fiddistrito_pd`
    FOREIGN KEY (`fiddistrito`)
    REFERENCES `distrito` (`iddistrito`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidpersona_pd`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `psicologo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `psicologo` ;

CREATE TABLE IF NOT EXISTS `psicologo` (
  `fidpersona` INT NOT NULL,
  `fidusuario` INT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidusuario_idx` (`fidusuario` ASC) VISIBLE,
  CONSTRAINT `fk_fidusuario_psi`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidpersona_psi`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `seguro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `seguro` ;

CREATE TABLE IF NOT EXISTS `seguro` (
  `idseguro` INT NOT NULL AUTO_INCREMENT,
  `proveedor` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idseguro`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `niño`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `niño` ;

CREATE TABLE IF NOT EXISTS `niño` (
  `fidpersona` INT NOT NULL,
  `fidseguro` INT NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidseguro_idx` (`fidseguro` ASC) VISIBLE,
  CONSTRAINT `fk_fidpersona_ni`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidseguro_ni`
    FOREIGN KEY (`fidseguro`)
    REFERENCES `seguro` (`idseguro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `grupo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `grupo` ;

CREATE TABLE IF NOT EXISTS `grupo` (
  `idgrupo` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `nombre` VARCHAR(25) NULL,
  PRIMARY KEY (`idgrupo`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) VISIBLE,
  CONSTRAINT `fk_fidmodulo_grupo`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `modulo` (`idmodulo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `niño_cuidador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `niño_cuidador` ;

CREATE TABLE IF NOT EXISTS `niño_cuidador` (
  `idniño_cuidador` INT NOT NULL AUTO_INCREMENT,
  `fidniño` INT NOT NULL,
  `fidcuidador` INT NOT NULL,
  PRIMARY KEY (`idniño_cuidador`),
  INDEX `fidniño_idx` (`fidniño` ASC) VISIBLE,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  CONSTRAINT `fk_fidniño_nc`
    FOREIGN KEY (`fidniño`)
    REFERENCES `niño` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidcuidador_nc`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `grupo_niño_cuidador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `grupo_niño_cuidador` ;

CREATE TABLE IF NOT EXISTS `grupo_niño_cuidador` (
  `idgrupo_niño_cuidador` INT NOT NULL AUTO_INCREMENT,
  `fidgrupo` INT NOT NULL,
  `fidniño_cuidador` INT NOT NULL,
  INDEX `fidniño_cuidador_idx` (`fidniño_cuidador` ASC) VISIBLE,
  PRIMARY KEY (`idgrupo_niño_cuidador`),
  CONSTRAINT `fk_fidgrupo_gnc`
    FOREIGN KEY (`fidgrupo`)
    REFERENCES `grupo` (`idgrupo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidniño_cuidador_gnc`
    FOREIGN KEY (`fidniño_cuidador`)
    REFERENCES `niño_cuidador` (`idniño_cuidador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `material` ;

CREATE TABLE IF NOT EXISTS `material` (
  `idmaterial` INT NOT NULL AUTO_INCREMENT,
  `tipoarchivo` VARCHAR(8) NULL,
  `link` VARCHAR(200) NULL,
  `descripcion` VARCHAR(75) NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idmaterial`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `eje`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `eje` ;

CREATE TABLE IF NOT EXISTS `eje` (
  `ideje` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ideje`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `modulo_eje`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `modulo_eje` ;

CREATE TABLE IF NOT EXISTS `modulo_eje` (
  `idmodulo_eje` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `fideje` INT NOT NULL,
  PRIMARY KEY (`idmodulo_eje`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) VISIBLE,
  INDEX `fideje_idx` (`fideje` ASC) VISIBLE,
  CONSTRAINT `fk_fidmodulo_meje`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `modulo` (`idmodulo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fideje_meje`
    FOREIGN KEY (`fideje`)
    REFERENCES `eje` (`ideje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `actividad_material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `actividad_material` ;

CREATE TABLE IF NOT EXISTS `actividad_material` (
  `idactividad_material` INT NOT NULL AUTO_INCREMENT,
  `fidactividad` INT NOT NULL,
  `fidmaterial` INT NOT NULL,
  PRIMARY KEY (`idactividad_material`),
  INDEX `fidactividad_idx` (`fidactividad` ASC) VISIBLE,
  INDEX `fidmaterial_idx` (`fidmaterial` ASC) VISIBLE,
  CONSTRAINT `fk_fidactividad_am`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `actividad` (`idactividad`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidmaterial_am`
    FOREIGN KEY (`fidmaterial`)
    REFERENCES `material` (`idmaterial`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `modulo_actividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `modulo_actividad` ;

CREATE TABLE IF NOT EXISTS `modulo_actividad` (
  `idmodulo_actividad` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `fidactividad` INT NOT NULL,
  PRIMARY KEY (`idmodulo_actividad`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) VISIBLE,
  INDEX `fidactividad_idx` (`fidactividad` ASC) VISIBLE,
  CONSTRAINT `fk_fidmodulo_ma`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `modulo` (`idmodulo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidactividad_ma`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `actividad` (`idactividad`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dia` ;

CREATE TABLE IF NOT EXISTS `dia` (
  `iddia` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`iddia`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cuidador_dia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cuidador_dia` ;

CREATE TABLE IF NOT EXISTS `cuidador_dia` (
  `idcuidador_dia` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fiddia` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_dia`),
  INDEX `fiddia_idx` (`fiddia` ASC) VISIBLE,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  CONSTRAINT `fk_fiddia_cd`
    FOREIGN KEY (`fiddia`)
    REFERENCES `dia` (`iddia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidcuidador_cd`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `periodo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `periodo` ;

CREATE TABLE IF NOT EXISTS `periodo` (
  `idperiodo` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`idperiodo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cuidador_periodo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cuidador_periodo` ;

CREATE TABLE IF NOT EXISTS `cuidador_periodo` (
  `idcuidador_periodo` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidperiodo` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_periodo`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  INDEX `fidperiodo_idx` (`fidperiodo` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_cp`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidperiodo_cp`
    FOREIGN KEY (`fidperiodo`)
    REFERENCES `periodo` (`idperiodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tipointernet`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tipointernet` ;

CREATE TABLE IF NOT EXISTS `tipointernet` (
  `idtipointernet` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idtipointernet`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cuidador_tipointernet`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cuidador_tipointernet` ;

CREATE TABLE IF NOT EXISTS `cuidador_tipointernet` (
  `idcuidador_tipointernet` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidtipointernet` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_tipointernet`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  INDEX `fidtipointernet_idx` (`fidtipointernet` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_ct`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidtipointernet_ct`
    FOREIGN KEY (`fidtipointernet`)
    REFERENCES `tipointernet` (`idtipointernet`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `redsocial`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `redsocial` ;

CREATE TABLE IF NOT EXISTS `redsocial` (
  `idredsocial` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idredsocial`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dispositivoelectronico`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dispositivoelectronico` ;

CREATE TABLE IF NOT EXISTS `dispositivoelectronico` (
  `iddispositivoelectronico` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`iddispositivoelectronico`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cuidador_redsocial`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cuidador_redsocial` ;

CREATE TABLE IF NOT EXISTS `cuidador_redsocial` (
  `idcuidador_redsocial` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidredsocial` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_redsocial`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  INDEX `fidredsocial_idx` (`fidredsocial` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_cr`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidredsocial_cr`
    FOREIGN KEY (`fidredsocial`)
    REFERENCES `redsocial` (`idredsocial`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cuidador_dispositivoelectronico`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cuidador_dispositivoelectronico` ;

CREATE TABLE IF NOT EXISTS `cuidador_dispositivoelectronico` (
  `idcuidador_dispositivoelectronico` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fiddispositivoelectronico` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_dispositivoelectronico`),
  INDEX `fiddispositivoelectronico_idx` (`fiddispositivoelectronico` ASC) VISIBLE,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  CONSTRAINT `fk_fiddispositivoelectronico_cdisp`
    FOREIGN KEY (`fiddispositivoelectronico`)
    REFERENCES `dispositivoelectronico` (`iddispositivoelectronico`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_fidcuidador_cdisp`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
