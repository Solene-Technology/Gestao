
-- ==========================
-- Banco de Dados Escolar - MySQL
-- ==========================

-- Cursos
CREATE TABLE Curso (
    CursoID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Duracao INT NOT NULL, -- duração em anos
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Turmas
CREATE TABLE Turma (
    TurmaID INT AUTO_INCREMENT PRIMARY KEY,
    CursoID INT NOT NULL,
    Nome VARCHAR(50) NOT NULL,
    Ano INT NOT NULL,
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CursoID) REFERENCES Curso(CursoID)
);

-- Professores
CREATE TABLE Professor (
    ProfessorID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Telefone VARCHAR(20),
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Disciplinas
CREATE TABLE Disciplina (
    DisciplinaID INT AUTO_INCREMENT PRIMARY KEY,
    CursoID INT NOT NULL,
    Nome VARCHAR(100) NOT NULL,
    CargaHoraria INT NOT NULL,
    ProfessorID INT NOT NULL,
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CursoID) REFERENCES Curso(CursoID),
    FOREIGN KEY (ProfessorID) REFERENCES Professor(ProfessorID)
);

-- Estudantes
CREATE TABLE Estudante (
    EstudanteID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Telefone VARCHAR(20),
    TurmaID INT NOT NULL,
    DataNascimento DATE,
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (TurmaID) REFERENCES Turma(TurmaID)
);

-- Usuários
CREATE TABLE Usuarios (
    Id INT NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    SenhaHash VARCHAR(255) NOT NULL,
    Perfil ENUM('Admin','Secretaria','Professor') NOT NULL,
    Ativo TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (Id)
);

-- Propinas / Mensalidades
CREATE TABLE PropinaMensal (
    PropinaMensalID INT AUTO_INCREMENT PRIMARY KEY,
    EstudanteID INT NOT NULL,
    Ano INT NOT NULL,
    Mes INT NOT NULL CHECK (Mes BETWEEN 1 AND 12),
    Valor DECIMAL(10,2) NOT NULL,
    Pago TINYINT(1) DEFAULT 0,
    DataPagamento DATE,
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (EstudanteID) REFERENCES Estudante(EstudanteID)
);

--  Relatórios
CREATE TABLE Relatorio (
    RelatorioID INT AUTO_INCREMENT PRIMARY KEY,
    EstudanteID INT NOT NULL,
    Tipo VARCHAR(50),
    CaminhoArquivo VARCHAR(255),
    CreateAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (EstudanteID) REFERENCES Estudante(EstudanteID)
);

-- Matrícula de estudante em disciplinas (N:N)
CREATE TABLE EstudanteDisciplina (
    EstudanteID INT NOT NULL,
    DisciplinaID INT NOT NULL,
    PRIMARY KEY (EstudanteID, DisciplinaID),
    FOREIGN KEY (EstudanteID) REFERENCES Estudante(EstudanteID),
    FOREIGN KEY (DisciplinaID) REFERENCES Disciplina(DisciplinaID)
);

