import * as React from 'react';
import { useState } from 'react';
import OptionsBar from './Component/OptionsBar';
import Container from 'react-bootstrap/Container';
import ResultBar from './Component/ResultBar';
import TopHeader from './Component/TopHeader';

export default function Main() {
  const [from, setFrom] = useState('Indonesia')
  const [to, setTo] = useState('Gorap') 

  // Switch values
  const switchValues = () => {
    setFrom((prevFrom) => prevFrom === 'Indonesia' ? 'Gorap' : 'Indonesia');
    setTo((prevTo) => prevTo === 'Gorap' ? 'Indonesia' : 'Gorap');
  };


    return (
      <>
        <TopHeader/>
         <Container className='' style={{width:'100vw'}}>            
            <OptionsBar to={to} from={from} switchValues={switchValues}/>
            <ResultBar to={to} from={from}/>                      
        </Container>
      </>
    );
  }