import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';



function EditData({ editVisibility }){
    return(
        <>
            <h4>Edit Data</h4>
            <Table bordered  responsive className='mt-2'>
                <tbody>
                    <tr>
                        <td><Form.Control type='text' placeholder='indonesia'/></td>
                        <td><Form.Control type='text' placeholder='gorap'/></td>
                        <td><Form.Control type='file' placeholder='audio' controlId="formFile"
                            style={{ width: '150px' }}
                        /></td>
                        <td><Form.Control type='text' placeholder='deskripsi'/></td>
                        <td><Button onClick={editVisibility} className='btn-sm btn-warning border'>Update</Button></td>
                    </tr>
                </tbody>
            </Table>
        </>
    );
}

export default EditData;