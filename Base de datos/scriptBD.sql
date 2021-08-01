use pruebauni;

Create Table Edificio (
idEdificio int NOT NULL,
PRIMARY KEY (idEdificio),
nombreEdificio varchar(20)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Aulas (
idAula int NOT NULL,
PRIMARY KEY (idAula),
nombreAula varchar(20),
idEdificio int,
FOREIGN KEY (idEdificio) REFERENCES Edificio(idEdificio)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Laboratorios (
idLab int NOT NULL,
PRIMARY KEY (idLab),
nombre Varchar(20),
idEdificio int,
idAula int,
FOREIGN KEY (idEdificio) REFERENCES Edificio(idEdificio),
FOREIGN KEY (idAula) REFERENCES Aulas(idAula)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Pensum (
idPensum int NOT NULL,
PRIMARY KEY (idPensum),
año int 
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Jornada (
idJornada int NOT NULL,
PRIMARY KEY (idJornada),
jornada varchar(20)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

Create Table Horarios(
idHorario int NOT NULL,
PRIMARY KEY (idHorario),
idJornada int,
dia varchar(10),
hora time,
FOREIGN KEY (idJornada) REFERENCES Jornada(idJornada)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

