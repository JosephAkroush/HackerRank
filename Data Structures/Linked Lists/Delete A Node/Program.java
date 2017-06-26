Node Delete(Node head, int position) {
    if (position == 0) {
        head = head.next;
    } else {
        Node node = head;
        
        while (--position > 0) {
            node = node.next;
        }
        
        node.next = node.next.next;
    }
    
    return head;
}
