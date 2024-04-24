// import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Button } from "react-bootstrap";


const BySearch = ({data,fetchData}) =>{
  const handleDelete = (id) => {
    axios.delete(`http://localhost:3001/api/contents/delete/${id}`)
      .then(response => {
          fetchData();
      })
      .catch(error => {
        console.error('Error deleting item:', error);
      });
  };

    return(
        <>  
            {data && data.map((item,index)=>(
                    <tr key={index}>
                        <td>{index+1}</td>
                        <td>{item.contentFrom}</td>
                        <td>{item.contentTo}</td>
                        <td>
                            <audio controls>
                                <source src="http://localhost:3001/api/Contents/audio/d42e3ab6-ec5c-4f50-8aca-09eda68d2eb5.mp3" type="audio/mpeg" />
                                Your browser does not support the audio element.
                            </audio>
                        </td>
                        <td>{item.contentDesc}</td>
                        <td>
                            {/* id : {item.id   }  */}
                            <Button className="btn-sm mx-2">Edit</Button>
                            <Button className="btn-sm btn-danger" onClick={() => handleDelete(item.id)}>delete</Button>
                        </td>
                    </tr>                     
            ))} 
        </>
    )
}

export default BySearch;