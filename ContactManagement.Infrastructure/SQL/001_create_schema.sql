CREATE TABLE IF NOT EXISTS contacts (
    id           INTEGER PRIMARY KEY AUTOINCREMENT,
    first_name   TEXT NOT NULL,
    last_name    TEXT NOT NULL,
    email        TEXT NOT NULL,
    phone        TEXT NULL,
    category     TEXT NOT NULL
                  CHECK (category IN ('Private','Business','Family')),
    company      TEXT NULL,
    website      TEXT NULL,
    notes        TEXT NULL,
    address      TEXT NULL,
    avatar_path  TEXT NULL,
    created_at   TEXT NOT NULL
                  DEFAULT (strftime('%Y-%m-%dT%H:%M:%fZ','now'))
);