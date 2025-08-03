import React from 'react';

export const ListofPlayers = () => {
  const players = [
    { name: 'Rohit', score: 88 },
    { name: 'Virat', score: 77 },
    { name: 'Dhoni', score: 45 },
    { name: 'KL Rahul', score: 69 },
    { name: 'Hardik', score: 92 },
    { name: 'Pant', score: 55 },
    { name: 'Jadeja', score: 34 },
    { name: 'Bumrah', score: 65 },
    { name: 'Shami', score: 76 },
    { name: 'Surya', score: 99 },
    { name: 'Gill', score: 81 }
  ];

  const below70 = players.filter(p => p.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((item, idx) => (
          <li key={idx}>Mr. {item.name} <span>{item.score}</span></li>
        ))}
      </ul>

      <h2>Players with Score &lt; 70</h2>
      <ul>
        {below70.map((item, idx) => (
          <li key={idx}>Mr. {item.name} <span>{item.score}</span></li>
        ))}
      </ul>
    </div>
  );
};
