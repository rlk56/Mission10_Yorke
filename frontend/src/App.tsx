import React from 'react';
import './App.css';
import Header from './header';
import BowlerData from './Bowlers/BowlerList';

function App() {
  return (
    <div className="App">
      <br />
      <Header />
      <br />
      <br />
      <BowlerData />
    </div>
  );
}

export default App;
