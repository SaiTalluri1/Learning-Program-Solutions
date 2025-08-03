import React from 'react';

// a. Odd Players using destructuring
export const OddPlayers = ({ players }) => {
  const [first, , third, , fifth] = players;

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        <li>First: {first}</li>
        <li>Third: {third}</li>
        <li>Fifth: {fifth}</li>
      </ul>
    </div>
  );
};


// b. Merging arrays using spread operator
export const AllIndianPlayers = () => {
  const T20Players = ['Rohit', 'Kohli', 'Surya'];
  const RanjiPlayers = ['Player4', 'Player5', 'Player6'];

  const merged = [...T20Players, ...RanjiPlayers];

  return (
    <div>
      <h2>All Indian Players</h2>
      <ul>
        {merged.map((player, idx) => (
          <li key={idx}>{player}</li>
        ))}
      </ul>
    </div>
  );
};
