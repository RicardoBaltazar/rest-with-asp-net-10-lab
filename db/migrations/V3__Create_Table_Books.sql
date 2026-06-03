CREATE TABLE books (
    id SERIAL PRIMARY KEY,
    title VARCHAR(255) NULL,
    author VARCHAR(255) NULL,
    price DECIMAL(18,2) NOT NULL,
    launch_date DATE NOT NULL
);
