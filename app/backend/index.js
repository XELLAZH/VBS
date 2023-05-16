const express = require('express');
const sqlite3 = require('sqlite3');
const path = require('path');

const PORT = process.env.PORT ?? 3001
const app = express()
const db = new sqlite3.Database('VBS.db');

const TEAMS = []

db.each('SELECT * FROM Teams', (err, row) => {
    TEAMS.push({id: row.id, name: row.name})
})
db.close()

app.get('/api/teams', (req, res) =>{
    res.status(200).json(TEAMS)
})



app.use(express.static(path.resolve('../frontend')))

app.get('*', (req, res) =>{
    res.sendFile(path.resolve('../frontend'))
})

app.listen(PORT, () => {
    console.log(`Server has been started on port: ${PORT}...`)
})