import { Bowler } from '../types/Bowler';
import { useEffect, useState } from 'react';
function BowlerData() {
  const [BowlerData, setBowlerData] = useState<Bowler[]>([]);
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5141/Bowler');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <table className="table table-bordered">
        <thead>
          <tr>
            <td>First Name</td>
            <td>Middle Initial</td>
            <td>Last Name</td>
            <td>Team Name</td>
            <td>Address</td>
            <td>City</td>
            <td>State</td>
            <td>Zip</td>
            <td>Phone Number</td>
          </tr>
        </thead>
        <tbody>
          {BowlerData.map((b) => (
            <tr key={b.bowlerId}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerData;
