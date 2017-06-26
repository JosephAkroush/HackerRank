void Print(Node head) {
    if (head == null) {
        return;
    }
    
    Node node = head;
    
    while (node != null) {
        System.out.println(node.data);
        
        node = node.next;
    }
}
