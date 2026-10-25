\set ON_ERROR_STOP on

CREATE TABLE IF NOT EXISTS keyboards (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name text NOT NULL UNIQUE,
    layout text NOT NULL
);

INSERT INTO keyboards (name, layout)
VALUES ('Lavender', '75%'), ('Lilac', '65%')
ON CONFLICT (name) DO NOTHING;

SELECT id, name, layout FROM keyboards ORDER BY id;
