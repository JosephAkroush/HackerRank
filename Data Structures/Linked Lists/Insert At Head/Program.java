Node Insert(Node head, int x) {
    Node node = new Node();
    node.next = head;
    node.data = x;

    return node;
}
