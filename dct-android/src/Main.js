import * as React from 'react';
import OptionsBar from './Component/OptionsBar';
import Container from 'react-bootstrap/Container';
import ResultBar from './Component/ResultBar';

export default function Main() {

    return (
      <>
         <Container className='border' style={{width:'400px'}}>
            <OptionsBar/>
            <ResultBar/>                      
        </Container>
      </>
    );
  }