CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    first_name NVARCHAR(50),
    last_name NVARCHAR(50),
    phone NVARCHAR(15),
    email NVARCHAR(100),
    password NVARCHAR(255),
    image NVARCHAR(255),
    birthday DATE
);

CREATE TABLE tasks (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NUll,
    header NVARCHAR(100),
    task NVARCHAR(MAX),
    start_date DATE,
    end_date DATE,
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE notes (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    header NVARCHAR(100),
    note NVARCHAR(MAX),
    date DATE DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE history (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    header NVARCHAR(100),
    date DATE DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES users(id)
);
